using System;
using DEYU.Singletons;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.InputSystem;

namespace NightScene.CookingUtility
{
	// Token: 0x020001B4 RID: 436
	public class QTERewardManager : MonoSingleton<QTERewardManager>
	{
		// Token: 0x06003547 RID: 13639 RVA: 0x00155C94 File Offset: 0x00153E94
		// Note: this type is marked as 'beforefieldinit'.
		static QTERewardManager()
		{
			Il2CppClassPointerStore<QTERewardManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.CookingUtility", "QTERewardManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QTERewardManager>.NativeClassPtr);
			QTERewardManager.NativeFieldInfoPtr_defaultBuffReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTERewardManager>.NativeClassPtr, "defaultBuffReward");
			QTERewardManager.NativeFieldInfoPtr_disableReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTERewardManager>.NativeClassPtr, "disableReward");
			QTERewardManager.NativeFieldInfoPtr_currentBuffReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTERewardManager>.NativeClassPtr, "currentBuffReward");
			QTERewardManager.NativeFieldInfoPtr_playerCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTERewardManager>.NativeClassPtr, "playerCharacter");
			QTERewardManager.NativeMethodInfoPtr_get_CurrentBuffReward_Public_get_QTEBuffReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTERewardManager>.NativeClassPtr, 100673466);
			QTERewardManager.NativeMethodInfoPtr_set_CurrentBuffReward_Public_set_Void_QTEBuffReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTERewardManager>.NativeClassPtr, 100673467);
			QTERewardManager.NativeMethodInfoPtr_ResetBuffReward_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTERewardManager>.NativeClassPtr, 100673468);
			QTERewardManager.NativeMethodInfoPtr_TryOpenRemotePanel_Public_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTERewardManager>.NativeClassPtr, 100673469);
			QTERewardManager.NativeMethodInfoPtr_OnQTESucceeded_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTERewardManager>.NativeClassPtr, 100673470);
			QTERewardManager.NativeMethodInfoPtr_Initialize_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTERewardManager>.NativeClassPtr, 100673471);
			QTERewardManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTERewardManager>.NativeClassPtr, 100673472);
			QTERewardManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTERewardManager>.NativeClassPtr, 100673473);
			QTERewardManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTERewardManager>.NativeClassPtr, 100673474);
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x06003548 RID: 13640 RVA: 0x00155DC8 File Offset: 0x00153FC8
		// (set) Token: 0x06003549 RID: 13641 RVA: 0x00155E08 File Offset: 0x00154008
		public unsafe QTEBuffReward CurrentBuffReward
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 126047, RefRangeEnd = 126060, XrefRangeStart = 126043, XrefRangeEnd = 126047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTERewardManager.NativeMethodInfoPtr_get_CurrentBuffReward_Public_get_QTEBuffReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<QTEBuffReward>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 126064, RefRangeEnd = 126065, XrefRangeStart = 126060, XrefRangeEnd = 126064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTERewardManager.NativeMethodInfoPtr_set_CurrentBuffReward_Public_set_Void_QTEBuffReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x00155E4C File Offset: 0x0015404C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126065, XrefRangeEnd = 126069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBuffReward()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTERewardManager.NativeMethodInfoPtr_ResetBuffReward_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x00155E80 File Offset: 0x00154080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126069, XrefRangeEnd = 126071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryOpenRemotePanel(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTERewardManager.NativeMethodInfoPtr_TryOpenRemotePanel_Public_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x00155EC8 File Offset: 0x001540C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 126072, RefRangeEnd = 126077, XrefRangeStart = 126071, XrefRangeEnd = 126072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnQTESucceeded(int index = -1, bool mustSuccess = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustSuccess;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTERewardManager.NativeMethodInfoPtr_OnQTESucceeded_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x00155F14 File Offset: 0x00154114
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 126112, RefRangeEnd = 126115, XrefRangeStart = 126077, XrefRangeEnd = 126112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Transform playerCharacter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerCharacter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTERewardManager.NativeMethodInfoPtr_Initialize_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x00155F58 File Offset: 0x00154158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126115, XrefRangeEnd = 126123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInstanceDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTERewardManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x00155F94 File Offset: 0x00154194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126123, XrefRangeEnd = 126126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTERewardManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x00155FD0 File Offset: 0x001541D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126126, XrefRangeEnd = 126129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QTERewardManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QTERewardManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTERewardManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x0001D8A7 File Offset: 0x0001BAA7
		public QTERewardManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x06003552 RID: 13650 RVA: 0x0015600C File Offset: 0x0015420C
		// (set) Token: 0x06003553 RID: 13651 RVA: 0x0001D8B0 File Offset: 0x0001BAB0
		public unsafe QTEBuffReward defaultBuffReward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTERewardManager.NativeFieldInfoPtr_defaultBuffReward);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTEBuffReward>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTERewardManager.NativeFieldInfoPtr_defaultBuffReward), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x06003554 RID: 13652 RVA: 0x0015603C File Offset: 0x0015423C
		// (set) Token: 0x06003555 RID: 13653 RVA: 0x0001D8CF File Offset: 0x0001BACF
		public unsafe bool disableReward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTERewardManager.NativeFieldInfoPtr_disableReward);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTERewardManager.NativeFieldInfoPtr_disableReward)) = value;
			}
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x06003556 RID: 13654 RVA: 0x00156064 File Offset: 0x00154264
		// (set) Token: 0x06003557 RID: 13655 RVA: 0x0001D8EA File Offset: 0x0001BAEA
		public unsafe QTEBuffReward currentBuffReward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTERewardManager.NativeFieldInfoPtr_currentBuffReward);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTEBuffReward>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTERewardManager.NativeFieldInfoPtr_currentBuffReward), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x06003558 RID: 13656 RVA: 0x00156094 File Offset: 0x00154294
		// (set) Token: 0x06003559 RID: 13657 RVA: 0x0001D909 File Offset: 0x0001BB09
		public unsafe Transform playerCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTERewardManager.NativeFieldInfoPtr_playerCharacter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTERewardManager.NativeFieldInfoPtr_playerCharacter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002405 RID: 9221
		private static readonly IntPtr NativeFieldInfoPtr_defaultBuffReward;

		// Token: 0x04002406 RID: 9222
		private static readonly IntPtr NativeFieldInfoPtr_disableReward;

		// Token: 0x04002407 RID: 9223
		private static readonly IntPtr NativeFieldInfoPtr_currentBuffReward;

		// Token: 0x04002408 RID: 9224
		private static readonly IntPtr NativeFieldInfoPtr_playerCharacter;

		// Token: 0x04002409 RID: 9225
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentBuffReward_Public_get_QTEBuffReward_0;

		// Token: 0x0400240A RID: 9226
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentBuffReward_Public_set_Void_QTEBuffReward_0;

		// Token: 0x0400240B RID: 9227
		private static readonly IntPtr NativeMethodInfoPtr_ResetBuffReward_Public_Void_0;

		// Token: 0x0400240C RID: 9228
		private static readonly IntPtr NativeMethodInfoPtr_TryOpenRemotePanel_Public_Void_CallbackContext_0;

		// Token: 0x0400240D RID: 9229
		private static readonly IntPtr NativeMethodInfoPtr_OnQTESucceeded_Public_Void_Int32_Boolean_0;

		// Token: 0x0400240E RID: 9230
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Transform_0;

		// Token: 0x0400240F RID: 9231
		private static readonly IntPtr NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04002410 RID: 9232
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04002411 RID: 9233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
