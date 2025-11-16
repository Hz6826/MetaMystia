using System;
using DEYU.Utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using NightScene;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.Tiles;
using NightScene.UI;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GameData.Profile
{
	// Token: 0x02000317 RID: 791
	public class QTEBuffReward : ScriptableObject
	{
		// Token: 0x06005E03 RID: 24067 RVA: 0x001D6F24 File Offset: 0x001D5124
		// Note: this type is marked as 'beforefieldinit'.
		static QTEBuffReward()
		{
			Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "QTEBuffReward");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr);
			QTEBuffReward.NativeFieldInfoPtr_currentTries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, "currentTries");
			QTEBuffReward.NativeFieldInfoPtr_qTEManagerContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, "qTEManagerContext");
			QTEBuffReward.NativeMethodInfoPtr_get_CanThrowDeliver_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, 100682605);
			QTEBuffReward.NativeMethodInfoPtr_get_CanOpenThrowDeliverPanel_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, 100682606);
			QTEBuffReward.NativeMethodInfoPtr_ApplyDurationMultiplier_Protected_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, 100682607);
			QTEBuffReward.NativeMethodInfoPtr_CheckPRD_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, 100682608);
			QTEBuffReward.NativeMethodInfoPtr_StopAllCoroutines_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, 100682609);
			QTEBuffReward.NativeMethodInfoPtr_SetContext_Public_Void_QTEManagerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, 100682610);
			QTEBuffReward.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, 100682611);
			QTEBuffReward.NativeMethodInfoPtr_OnQTESucceeded_Public_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, 100682612);
			QTEBuffReward.NativeMethodInfoPtr_TryExecuteThrowDeliver_Public_Virtual_New_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, 100682613);
			QTEBuffReward.NativeMethodInfoPtr_TryExecuteThrowDeliver_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, 100682614);
			QTEBuffReward.NativeMethodInfoPtr_OnFocusingDeskChanged_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, 100682615);
			QTEBuffReward.NativeMethodInfoPtr_ToggleThrowDeliverIndicator_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, 100682616);
			QTEBuffReward.NativeMethodInfoPtr_ClearAllBuff_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, 100682617);
			QTEBuffReward.NativeMethodInfoPtr_QTEBuffOwnerIdentifier_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, 100682618);
			QTEBuffReward.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, 100682619);
			QTEBuffReward.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, 100682620);
		}

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x06005E04 RID: 24068 RVA: 0x001D70BC File Offset: 0x001D52BC
		public unsafe bool CanThrowDeliver
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233835, XrefRangeEnd = 233837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEBuffReward.NativeMethodInfoPtr_get_CanThrowDeliver_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x06005E05 RID: 24069 RVA: 0x001D70F8 File Offset: 0x001D52F8
		public unsafe bool CanOpenThrowDeliverPanel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233837, XrefRangeEnd = 233839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEBuffReward.NativeMethodInfoPtr_get_CanOpenThrowDeliverPanel_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005E06 RID: 24070 RVA: 0x001D7134 File Offset: 0x001D5334
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 233845, RefRangeEnd = 233861, XrefRangeStart = 233839, XrefRangeEnd = 233845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ApplyDurationMultiplier(int sourceDuration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sourceDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEBuffReward.NativeMethodInfoPtr_ApplyDurationMultiplier_Protected_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E07 RID: 24071 RVA: 0x001D7180 File Offset: 0x001D5380
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 233868, RefRangeEnd = 233872, XrefRangeStart = 233861, XrefRangeEnd = 233868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckPRD()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEBuffReward.NativeMethodInfoPtr_CheckPRD_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E08 RID: 24072 RVA: 0x001D71BC File Offset: 0x001D53BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233872, XrefRangeEnd = 233874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAllCoroutines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEBuffReward.NativeMethodInfoPtr_StopAllCoroutines_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E09 RID: 24073 RVA: 0x001D71F0 File Offset: 0x001D53F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233874, XrefRangeEnd = 233875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContext(QTEBuffReward.QTEManagerContext qTEManagerContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(qTEManagerContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEBuffReward.NativeMethodInfoPtr_SetContext_Public_Void_QTEManagerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E0A RID: 24074 RVA: 0x001D7238 File Offset: 0x001D5438
		[CallerCount(0)]
		public unsafe virtual void Initialize(Transform playerCharacter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerCharacter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEBuffReward.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E0B RID: 24075 RVA: 0x001D7288 File Offset: 0x001D5488
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnQTESucceeded(int index = -1, bool mustSuccess = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustSuccess;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEBuffReward.NativeMethodInfoPtr_OnQTESucceeded_Public_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E0C RID: 24076 RVA: 0x001D72E0 File Offset: 0x001D54E0
		[CallerCount(0)]
		public unsafe virtual void TryExecuteThrowDeliver(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEBuffReward.NativeMethodInfoPtr_TryExecuteThrowDeliver_Public_Virtual_New_Void_CallbackContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E0D RID: 24077 RVA: 0x001D7334 File Offset: 0x001D5534
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TryExecuteThrowDeliver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEBuffReward.NativeMethodInfoPtr_TryExecuteThrowDeliver_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E0E RID: 24078 RVA: 0x001D7370 File Offset: 0x001D5570
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnFocusingDeskChanged(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEBuffReward.NativeMethodInfoPtr_OnFocusingDeskChanged_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E0F RID: 24079 RVA: 0x001D73BC File Offset: 0x001D55BC
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ToggleThrowDeliverIndicator(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEBuffReward.NativeMethodInfoPtr_ToggleThrowDeliverIndicator_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E10 RID: 24080 RVA: 0x001D7408 File Offset: 0x001D5608
		[CallerCount(0)]
		public unsafe virtual void ClearAllBuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEBuffReward.NativeMethodInfoPtr_ClearAllBuff_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E11 RID: 24081 RVA: 0x001D7444 File Offset: 0x001D5644
		[CallerCount(0)]
		public unsafe virtual string QTEBuffOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEBuffReward.NativeMethodInfoPtr_QTEBuffOwnerIdentifier_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E12 RID: 24082 RVA: 0x001D7488 File Offset: 0x001D5688
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEBuffReward.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E13 RID: 24083 RVA: 0x001D74C4 File Offset: 0x001D56C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QTEBuffReward() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEBuffReward.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E14 RID: 24084 RVA: 0x00033452 File Offset: 0x00031652
		public QTEBuffReward(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x06005E15 RID: 24085 RVA: 0x001D7500 File Offset: 0x001D5700
		// (set) Token: 0x06005E16 RID: 24086 RVA: 0x0003345B File Offset: 0x0003165B
		public unsafe int currentTries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.NativeFieldInfoPtr_currentTries);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.NativeFieldInfoPtr_currentTries)) = value;
			}
		}

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x06005E17 RID: 24087 RVA: 0x001D7528 File Offset: 0x001D5728
		// (set) Token: 0x06005E18 RID: 24088 RVA: 0x00033476 File Offset: 0x00031676
		public QTEBuffReward.QTEManagerContext qTEManagerContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.NativeFieldInfoPtr_qTEManagerContext);
				return new QTEBuffReward.QTEManagerContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QTEBuffReward.QTEManagerContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.NativeFieldInfoPtr_qTEManagerContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<QTEBuffReward.QTEManagerContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04003E33 RID: 15923
		private static readonly IntPtr NativeFieldInfoPtr_currentTries;

		// Token: 0x04003E34 RID: 15924
		private static readonly IntPtr NativeFieldInfoPtr_qTEManagerContext;

		// Token: 0x04003E35 RID: 15925
		private static readonly IntPtr NativeMethodInfoPtr_get_CanThrowDeliver_Protected_get_Boolean_0;

		// Token: 0x04003E36 RID: 15926
		private static readonly IntPtr NativeMethodInfoPtr_get_CanOpenThrowDeliverPanel_Protected_get_Boolean_0;

		// Token: 0x04003E37 RID: 15927
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDurationMultiplier_Protected_Int32_Int32_0;

		// Token: 0x04003E38 RID: 15928
		private static readonly IntPtr NativeMethodInfoPtr_CheckPRD_Protected_Boolean_0;

		// Token: 0x04003E39 RID: 15929
		private static readonly IntPtr NativeMethodInfoPtr_StopAllCoroutines_Protected_Void_0;

		// Token: 0x04003E3A RID: 15930
		private static readonly IntPtr NativeMethodInfoPtr_SetContext_Public_Void_QTEManagerContext_0;

		// Token: 0x04003E3B RID: 15931
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_Transform_0;

		// Token: 0x04003E3C RID: 15932
		private static readonly IntPtr NativeMethodInfoPtr_OnQTESucceeded_Public_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x04003E3D RID: 15933
		private static readonly IntPtr NativeMethodInfoPtr_TryExecuteThrowDeliver_Public_Virtual_New_Void_CallbackContext_0;

		// Token: 0x04003E3E RID: 15934
		private static readonly IntPtr NativeMethodInfoPtr_TryExecuteThrowDeliver_Public_Virtual_New_Void_0;

		// Token: 0x04003E3F RID: 15935
		private static readonly IntPtr NativeMethodInfoPtr_OnFocusingDeskChanged_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04003E40 RID: 15936
		private static readonly IntPtr NativeMethodInfoPtr_ToggleThrowDeliverIndicator_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04003E41 RID: 15937
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllBuff_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04003E42 RID: 15938
		private static readonly IntPtr NativeMethodInfoPtr_QTEBuffOwnerIdentifier_Public_Abstract_Virtual_New_String_0;

		// Token: 0x04003E43 RID: 15939
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0;

		// Token: 0x04003E44 RID: 15940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000D39 RID: 3385
		public sealed class QTEManagerContext : ValueType
		{
			// Token: 0x0600F368 RID: 62312 RVA: 0x00399F80 File Offset: 0x00398180
			// Note: this type is marked as 'beforefieldinit'.
			static QTEManagerContext()
			{
				Il2CppClassPointerStore<QTEBuffReward.QTEManagerContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QTEBuffReward>.NativeClassPtr, "QTEManagerContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QTEBuffReward.QTEManagerContext>.NativeClassPtr);
				QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_EventManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEBuffReward.QTEManagerContext>.NativeClassPtr, "EventManagerInstance");
				QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_UIManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEBuffReward.QTEManagerContext>.NativeClassPtr, "UIManagerInstance");
				QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_GuestsManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEBuffReward.QTEManagerContext>.NativeClassPtr, "GuestsManagerInstance");
				QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_CookSystemManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEBuffReward.QTEManagerContext>.NativeClassPtr, "CookSystemManagerInstance");
				QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_PRDInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEBuffReward.QTEManagerContext>.NativeClassPtr, "PRDInstance");
				QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_TileManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEBuffReward.QTEManagerContext>.NativeClassPtr, "TileManagerInstance");
				QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_NightSceneDirectorInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEBuffReward.QTEManagerContext>.NativeClassPtr, "NightSceneDirectorInstance");
				QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_SceneManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEBuffReward.QTEManagerContext>.NativeClassPtr, "SceneManagerInstance");
				QTEBuffReward.QTEManagerContext.NativeMethodInfoPtr__ctor_Public_Void_EventManager_UIManager_GuestsManager_CookSystemManager_PRD_TileManager_NightSceneDirector_SceneManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEBuffReward.QTEManagerContext>.NativeClassPtr, 100682621);
			}

			// Token: 0x0600F369 RID: 62313 RVA: 0x0039A060 File Offset: 0x00398260
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 72838, RefRangeEnd = 72841, XrefRangeStart = 72838, XrefRangeEnd = 72841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe QTEManagerContext(EventManager eventManagerInstance, UIManager uIManagerInstance, GuestsManager guestsManagerInstance, CookSystemManager cookSystemManagerInstance, PRD pRDInstance, TileManager tileManagerInstance, NightSceneDirector nightSceneDirectorInstance, SceneManager sceneManagerInstance) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QTEBuffReward.QTEManagerContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManagerInstance);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uIManagerInstance);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestsManagerInstance);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookSystemManagerInstance);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRDInstance);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tileManagerInstance);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nightSceneDirectorInstance);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sceneManagerInstance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEBuffReward.QTEManagerContext.NativeMethodInfoPtr__ctor_Public_Void_EventManager_UIManager_GuestsManager_CookSystemManager_PRD_TileManager_NightSceneDirector_SceneManager_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F36A RID: 62314 RVA: 0x00082A77 File Offset: 0x00080C77
			public QTEManagerContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600F36B RID: 62315 RVA: 0x00082A80 File Offset: 0x00080C80
			public QTEManagerContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QTEBuffReward.QTEManagerContext>.NativeClassPtr))
			{
			}

			// Token: 0x17004F20 RID: 20256
			// (get) Token: 0x0600F36C RID: 62316 RVA: 0x0039A134 File Offset: 0x00398334
			// (set) Token: 0x0600F36D RID: 62317 RVA: 0x00082A92 File Offset: 0x00080C92
			public unsafe EventManager EventManagerInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_EventManagerInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_EventManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F21 RID: 20257
			// (get) Token: 0x0600F36E RID: 62318 RVA: 0x0039A164 File Offset: 0x00398364
			// (set) Token: 0x0600F36F RID: 62319 RVA: 0x00082AB1 File Offset: 0x00080CB1
			public unsafe UIManager UIManagerInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_UIManagerInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_UIManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F22 RID: 20258
			// (get) Token: 0x0600F370 RID: 62320 RVA: 0x0039A194 File Offset: 0x00398394
			// (set) Token: 0x0600F371 RID: 62321 RVA: 0x00082AD0 File Offset: 0x00080CD0
			public unsafe GuestsManager GuestsManagerInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_GuestsManagerInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_GuestsManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F23 RID: 20259
			// (get) Token: 0x0600F372 RID: 62322 RVA: 0x0039A1C4 File Offset: 0x003983C4
			// (set) Token: 0x0600F373 RID: 62323 RVA: 0x00082AEF File Offset: 0x00080CEF
			public unsafe CookSystemManager CookSystemManagerInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_CookSystemManagerInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookSystemManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_CookSystemManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F24 RID: 20260
			// (get) Token: 0x0600F374 RID: 62324 RVA: 0x0039A1F4 File Offset: 0x003983F4
			// (set) Token: 0x0600F375 RID: 62325 RVA: 0x00082B0E File Offset: 0x00080D0E
			public unsafe PRD PRDInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_PRDInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PRD>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_PRDInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F25 RID: 20261
			// (get) Token: 0x0600F376 RID: 62326 RVA: 0x0039A224 File Offset: 0x00398424
			// (set) Token: 0x0600F377 RID: 62327 RVA: 0x00082B2D File Offset: 0x00080D2D
			public unsafe TileManager TileManagerInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_TileManagerInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_TileManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F26 RID: 20262
			// (get) Token: 0x0600F378 RID: 62328 RVA: 0x0039A254 File Offset: 0x00398454
			// (set) Token: 0x0600F379 RID: 62329 RVA: 0x00082B4C File Offset: 0x00080D4C
			public unsafe NightSceneDirector NightSceneDirectorInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_NightSceneDirectorInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NightSceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_NightSceneDirectorInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F27 RID: 20263
			// (get) Token: 0x0600F37A RID: 62330 RVA: 0x0039A284 File Offset: 0x00398484
			// (set) Token: 0x0600F37B RID: 62331 RVA: 0x00082B6B File Offset: 0x00080D6B
			public unsafe SceneManager SceneManagerInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_SceneManagerInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEBuffReward.QTEManagerContext.NativeFieldInfoPtr_SceneManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B08 RID: 39688
			private static readonly IntPtr NativeFieldInfoPtr_EventManagerInstance;

			// Token: 0x04009B09 RID: 39689
			private static readonly IntPtr NativeFieldInfoPtr_UIManagerInstance;

			// Token: 0x04009B0A RID: 39690
			private static readonly IntPtr NativeFieldInfoPtr_GuestsManagerInstance;

			// Token: 0x04009B0B RID: 39691
			private static readonly IntPtr NativeFieldInfoPtr_CookSystemManagerInstance;

			// Token: 0x04009B0C RID: 39692
			private static readonly IntPtr NativeFieldInfoPtr_PRDInstance;

			// Token: 0x04009B0D RID: 39693
			private static readonly IntPtr NativeFieldInfoPtr_TileManagerInstance;

			// Token: 0x04009B0E RID: 39694
			private static readonly IntPtr NativeFieldInfoPtr_NightSceneDirectorInstance;

			// Token: 0x04009B0F RID: 39695
			private static readonly IntPtr NativeFieldInfoPtr_SceneManagerInstance;

			// Token: 0x04009B10 RID: 39696
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventManager_UIManager_GuestsManager_CookSystemManager_PRD_TileManager_NightSceneDirector_SceneManager_0;
		}
	}
}
