using System;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Night.BossBattle.DLC5_MizuchiBossBattle
{
	// Token: 0x02000070 RID: 112
	public class DLC5_MoonEyeControllerPanel : UIPanelParam<DLC5_MoonEyeControllerPanel.OpenContext, float>
	{
		// Token: 0x06000C21 RID: 3105 RVA: 0x000C6A7C File Offset: 0x000C4C7C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_MoonEyeControllerPanel()
		{
			Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC5_MizuchiBossBattle", "DLC5_MoonEyeControllerPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr);
			DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_canMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, "canMove");
			DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_remainingAnimationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, "remainingAnimationTime");
			DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_remainingAnimationEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, "remainingAnimationEndTime");
			DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_remainingCouldUseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, "remainingCouldUseTime");
			DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_moveDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, "moveDirection");
			DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_hasFinded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, "hasFinded");
			DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_isClosing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, "isClosing");
			DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_isClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, "isClosed");
			DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_openContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, "openContext");
			DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_realRemainingCouldUseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, "realRemainingCouldUseTime");
			DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_INPUT_CUTOFF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, "INPUT_CUTOFF");
			DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, 100665351);
			DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, 100665352);
			DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, 100665353);
			DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, 100665354);
			DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_TryClose_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, 100665355);
			DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_MoveMirror_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, 100665356);
			DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_CancelInput_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, 100665357);
			DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_SetMirrorPosition_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, 100665358);
			DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, 100665359);
			DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, 100665360);
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x000C6C50 File Offset: 0x000C4E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42819, XrefRangeEnd = 42838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x000C6C8C File Offset: 0x000C4E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42838, XrefRangeEnd = 42866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(DLC5_MoonEyeControllerPanel.OpenContext openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x000C6CE0 File Offset: 0x000C4EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42866, XrefRangeEnd = 42892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose(float closeParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref closeParam;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x000C6D2C File Offset: 0x000C4F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42892, XrefRangeEnd = 42894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x000C6D60 File Offset: 0x000C4F60
		[CallerCount(0)]
		public unsafe void TryClose(InputAction.CallbackContext obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_TryClose_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x000C6DA8 File Offset: 0x000C4FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42894, XrefRangeEnd = 42913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveMirror(InputAction.CallbackContext x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_MoveMirror_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x000C6DF0 File Offset: 0x000C4FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42913, XrefRangeEnd = 42915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelInput(InputAction.CallbackContext obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_CancelInput_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x000C6E38 File Offset: 0x000C5038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42920, RefRangeEnd = 42921, XrefRangeStart = 42915, XrefRangeEnd = 42920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMirrorPosition(Vector2 targetPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_SetMirrorPosition_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x000C6E78 File Offset: 0x000C5078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42921, XrefRangeEnd = 42922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x000C6EB4 File Offset: 0x000C50B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42922, XrefRangeEnd = 42925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_MoonEyeControllerPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MoonEyeControllerPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x000086A4 File Offset: 0x000068A4
		public DLC5_MoonEyeControllerPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x000C6EF0 File Offset: 0x000C50F0
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x000086AD File Offset: 0x000068AD
		public unsafe bool canMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_canMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_canMove)) = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x000C6F18 File Offset: 0x000C5118
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x000086C8 File Offset: 0x000068C8
		public unsafe float remainingAnimationTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_remainingAnimationTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_remainingAnimationTime)) = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x000C6F40 File Offset: 0x000C5140
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x000086E3 File Offset: 0x000068E3
		public unsafe float remainingAnimationEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_remainingAnimationEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_remainingAnimationEndTime)) = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x000C6F68 File Offset: 0x000C5168
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x000086FE File Offset: 0x000068FE
		public unsafe float remainingCouldUseTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_remainingCouldUseTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_remainingCouldUseTime)) = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x000C6F90 File Offset: 0x000C5190
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x00008719 File Offset: 0x00006919
		public unsafe Vector2 moveDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_moveDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_moveDirection)) = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x000C6FB8 File Offset: 0x000C51B8
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x00008734 File Offset: 0x00006934
		public unsafe bool hasFinded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_hasFinded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_hasFinded)) = value;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x000C6FE0 File Offset: 0x000C51E0
		// (set) Token: 0x06000C3A RID: 3130 RVA: 0x0000874F File Offset: 0x0000694F
		public unsafe bool isClosing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_isClosing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_isClosing)) = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x000C7008 File Offset: 0x000C5208
		// (set) Token: 0x06000C3C RID: 3132 RVA: 0x0000876A File Offset: 0x0000696A
		public unsafe bool isClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_isClosed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_isClosed)) = value;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x000C7030 File Offset: 0x000C5230
		// (set) Token: 0x06000C3E RID: 3134 RVA: 0x00008785 File Offset: 0x00006985
		public DLC5_MoonEyeControllerPanel.OpenContext openContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_openContext);
				return new DLC5_MoonEyeControllerPanel.OpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_openContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x000C7060 File Offset: 0x000C5260
		// (set) Token: 0x06000C40 RID: 3136 RVA: 0x000087B3 File Offset: 0x000069B3
		public unsafe float realRemainingCouldUseTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_realRemainingCouldUseTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_realRemainingCouldUseTime)) = value;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x000C7088 File Offset: 0x000C5288
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x000087CE File Offset: 0x000069CE
		public unsafe static float INPUT_CUTOFF
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_INPUT_CUTOFF, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_MoonEyeControllerPanel.NativeFieldInfoPtr_INPUT_CUTOFF, (void*)(&value));
			}
		}

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeFieldInfoPtr_canMove;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeFieldInfoPtr_remainingAnimationTime;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeFieldInfoPtr_remainingAnimationEndTime;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeFieldInfoPtr_remainingCouldUseTime;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeFieldInfoPtr_moveDirection;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeFieldInfoPtr_hasFinded;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeFieldInfoPtr_isClosing;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeFieldInfoPtr_isClosed;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeFieldInfoPtr_openContext;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeFieldInfoPtr_realRemainingCouldUseTime;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeFieldInfoPtr_INPUT_CUTOFF;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_Single_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_TryClose_Private_Void_CallbackContext_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_MoveMirror_Private_Void_CallbackContext_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_CancelInput_Private_Void_CallbackContext_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_SetMirrorPosition_Private_Void_Vector2_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000538 RID: 1336
		public sealed class OpenContext : ValueType
		{
			// Token: 0x0600866C RID: 34412 RVA: 0x002581C8 File Offset: 0x002563C8
			// Note: this type is marked as 'beforefieldinit'.
			static OpenContext()
			{
				Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, "OpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr);
				DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_TargetMirror = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr, "TargetMirror");
				DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_PlayerTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr, "PlayerTransform");
				DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_MaxCouldUseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr, "MaxCouldUseTime");
				DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_MirrorRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr, "MirrorRadius");
				DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_WaitForAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr, "WaitForAnimator");
				DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr, "MoveSpeed");
				DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_OffsetOfPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr, "OffsetOfPlayer");
				DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_OnFindMizuchiCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr, "OnFindMizuchiCallback");
				DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_MizuchiPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr, "MizuchiPosition");
				DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_OnUpdateMirrorProgressCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr, "OnUpdateMirrorProgressCallback");
				DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_WaitForAnimatorEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr, "WaitForAnimatorEnd");
				DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_SetEndAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr, "SetEndAnimator");
				DLC5_MoonEyeControllerPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_Transform_Transform_Single_Single_Single_Single_Vector2_Action_Nullable_1_Vector2_Action_1_Single_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr, 100665361);
			}

			// Token: 0x0600866D RID: 34413 RVA: 0x002582F8 File Offset: 0x002564F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 42814, RefRangeEnd = 42815, XrefRangeStart = 42809, XrefRangeEnd = 42814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenContext(Transform targetMirror, Transform playerTransform, float maxCouldUseTime, float mirrorRadius, float waitForAnimator, float moveSpeed, Vector2 offsetOfPlayer, Action onFindMizuchiCallback, Nullable<Vector2> mizuchiPosition, Action<float> onUpdateMirrorProgressCallback, float waitForAnimatorEnd, Action setEndAnimator) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetMirror);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerTransform);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCouldUseTime;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mirrorRadius;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitForAnimator;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeed;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetOfPlayer;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFindMizuchiCallback);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(mizuchiPosition));
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onUpdateMirrorProgressCallback);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitForAnimatorEnd;
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setEndAnimator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MoonEyeControllerPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_Transform_Transform_Single_Single_Single_Single_Vector2_Action_Nullable_1_Vector2_Action_1_Single_Single_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600866E RID: 34414 RVA: 0x000484A0 File Offset: 0x000466A0
			public OpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600866F RID: 34415 RVA: 0x000484A9 File Offset: 0x000466A9
			public OpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.OpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x17002D15 RID: 11541
			// (get) Token: 0x06008670 RID: 34416 RVA: 0x00258404 File Offset: 0x00256604
			// (set) Token: 0x06008671 RID: 34417 RVA: 0x000484BB File Offset: 0x000466BB
			public unsafe Transform TargetMirror
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_TargetMirror);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_TargetMirror), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D16 RID: 11542
			// (get) Token: 0x06008672 RID: 34418 RVA: 0x00258434 File Offset: 0x00256634
			// (set) Token: 0x06008673 RID: 34419 RVA: 0x000484DA File Offset: 0x000466DA
			public unsafe Transform PlayerTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_PlayerTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_PlayerTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D17 RID: 11543
			// (get) Token: 0x06008674 RID: 34420 RVA: 0x00258464 File Offset: 0x00256664
			// (set) Token: 0x06008675 RID: 34421 RVA: 0x000484F9 File Offset: 0x000466F9
			public unsafe float MaxCouldUseTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_MaxCouldUseTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_MaxCouldUseTime)) = value;
				}
			}

			// Token: 0x17002D18 RID: 11544
			// (get) Token: 0x06008676 RID: 34422 RVA: 0x0025848C File Offset: 0x0025668C
			// (set) Token: 0x06008677 RID: 34423 RVA: 0x00048514 File Offset: 0x00046714
			public unsafe float MirrorRadius
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_MirrorRadius);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_MirrorRadius)) = value;
				}
			}

			// Token: 0x17002D19 RID: 11545
			// (get) Token: 0x06008678 RID: 34424 RVA: 0x002584B4 File Offset: 0x002566B4
			// (set) Token: 0x06008679 RID: 34425 RVA: 0x0004852F File Offset: 0x0004672F
			public unsafe float WaitForAnimator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_WaitForAnimator);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_WaitForAnimator)) = value;
				}
			}

			// Token: 0x17002D1A RID: 11546
			// (get) Token: 0x0600867A RID: 34426 RVA: 0x002584DC File Offset: 0x002566DC
			// (set) Token: 0x0600867B RID: 34427 RVA: 0x0004854A File Offset: 0x0004674A
			public unsafe float MoveSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_MoveSpeed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_MoveSpeed)) = value;
				}
			}

			// Token: 0x17002D1B RID: 11547
			// (get) Token: 0x0600867C RID: 34428 RVA: 0x00258504 File Offset: 0x00256704
			// (set) Token: 0x0600867D RID: 34429 RVA: 0x00048565 File Offset: 0x00046765
			public unsafe Vector2 OffsetOfPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_OffsetOfPlayer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_OffsetOfPlayer)) = value;
				}
			}

			// Token: 0x17002D1C RID: 11548
			// (get) Token: 0x0600867E RID: 34430 RVA: 0x0025852C File Offset: 0x0025672C
			// (set) Token: 0x0600867F RID: 34431 RVA: 0x00048580 File Offset: 0x00046780
			public unsafe Action OnFindMizuchiCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_OnFindMizuchiCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_OnFindMizuchiCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D1D RID: 11549
			// (get) Token: 0x06008680 RID: 34432 RVA: 0x0025855C File Offset: 0x0025675C
			// (set) Token: 0x06008681 RID: 34433 RVA: 0x0004859F File Offset: 0x0004679F
			public Nullable<Vector2> MizuchiPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_MizuchiPosition);
					return new Nullable<Vector2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector2>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_MizuchiPosition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector2>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002D1E RID: 11550
			// (get) Token: 0x06008682 RID: 34434 RVA: 0x0025858C File Offset: 0x0025678C
			// (set) Token: 0x06008683 RID: 34435 RVA: 0x000485CD File Offset: 0x000467CD
			public unsafe Action<float> OnUpdateMirrorProgressCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_OnUpdateMirrorProgressCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_OnUpdateMirrorProgressCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D1F RID: 11551
			// (get) Token: 0x06008684 RID: 34436 RVA: 0x002585BC File Offset: 0x002567BC
			// (set) Token: 0x06008685 RID: 34437 RVA: 0x000485EC File Offset: 0x000467EC
			public unsafe float WaitForAnimatorEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_WaitForAnimatorEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_WaitForAnimatorEnd)) = value;
				}
			}

			// Token: 0x17002D20 RID: 11552
			// (get) Token: 0x06008686 RID: 34438 RVA: 0x002585E4 File Offset: 0x002567E4
			// (set) Token: 0x06008687 RID: 34439 RVA: 0x00048607 File Offset: 0x00046807
			public unsafe Action SetEndAnimator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_SetEndAnimator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_MoonEyeControllerPanel.OpenContext.NativeFieldInfoPtr_SetEndAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005843 RID: 22595
			private static readonly IntPtr NativeFieldInfoPtr_TargetMirror;

			// Token: 0x04005844 RID: 22596
			private static readonly IntPtr NativeFieldInfoPtr_PlayerTransform;

			// Token: 0x04005845 RID: 22597
			private static readonly IntPtr NativeFieldInfoPtr_MaxCouldUseTime;

			// Token: 0x04005846 RID: 22598
			private static readonly IntPtr NativeFieldInfoPtr_MirrorRadius;

			// Token: 0x04005847 RID: 22599
			private static readonly IntPtr NativeFieldInfoPtr_WaitForAnimator;

			// Token: 0x04005848 RID: 22600
			private static readonly IntPtr NativeFieldInfoPtr_MoveSpeed;

			// Token: 0x04005849 RID: 22601
			private static readonly IntPtr NativeFieldInfoPtr_OffsetOfPlayer;

			// Token: 0x0400584A RID: 22602
			private static readonly IntPtr NativeFieldInfoPtr_OnFindMizuchiCallback;

			// Token: 0x0400584B RID: 22603
			private static readonly IntPtr NativeFieldInfoPtr_MizuchiPosition;

			// Token: 0x0400584C RID: 22604
			private static readonly IntPtr NativeFieldInfoPtr_OnUpdateMirrorProgressCallback;

			// Token: 0x0400584D RID: 22605
			private static readonly IntPtr NativeFieldInfoPtr_WaitForAnimatorEnd;

			// Token: 0x0400584E RID: 22606
			private static readonly IntPtr NativeFieldInfoPtr_SetEndAnimator;

			// Token: 0x0400584F RID: 22607
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_Transform_Single_Single_Single_Single_Vector2_Action_Nullable_1_Vector2_Action_1_Single_Single_Action_0;
		}

		// Token: 0x02000539 RID: 1337
		[ObfuscatedName("Night.BossBattle.DLC5_MizuchiBossBattle.DLC5_MoonEyeControllerPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008688 RID: 34440 RVA: 0x00258614 File Offset: 0x00256814
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.__c>.NativeClassPtr);
				DLC5_MoonEyeControllerPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.__c>.NativeClassPtr, "<>9");
				DLC5_MoonEyeControllerPanel.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.__c>.NativeClassPtr, "<>9__17_0");
				DLC5_MoonEyeControllerPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.__c>.NativeClassPtr, 100665363);
				DLC5_MoonEyeControllerPanel.__c.NativeMethodInfoPtr__MoveMirror_b__17_0_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.__c>.NativeClassPtr, 100665364);
			}

			// Token: 0x06008689 RID: 34441 RVA: 0x00258690 File Offset: 0x00256890
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_MoonEyeControllerPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MoonEyeControllerPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600868A RID: 34442 RVA: 0x002586CC File Offset: 0x002568CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42815, XrefRangeEnd = 42819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _MoveMirror_b__17_0(float y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_MoonEyeControllerPanel.__c.NativeMethodInfoPtr__MoveMirror_b__17_0_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600868B RID: 34443 RVA: 0x00048626 File Offset: 0x00046826
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002D21 RID: 11553
			// (get) Token: 0x0600868C RID: 34444 RVA: 0x00258718 File Offset: 0x00256918
			// (set) Token: 0x0600868D RID: 34445 RVA: 0x0004862F File Offset: 0x0004682F
			public unsafe static DLC5_MoonEyeControllerPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MoonEyeControllerPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_MoonEyeControllerPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MoonEyeControllerPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D22 RID: 11554
			// (get) Token: 0x0600868E RID: 34446 RVA: 0x00258740 File Offset: 0x00256940
			// (set) Token: 0x0600868F RID: 34447 RVA: 0x00048641 File Offset: 0x00046841
			public unsafe static Func<float, float> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_MoonEyeControllerPanel.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_MoonEyeControllerPanel.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005850 RID: 22608
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005851 RID: 22609
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04005852 RID: 22610
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005853 RID: 22611
			private static readonly IntPtr NativeMethodInfoPtr__MoveMirror_b__17_0_Internal_Single_Single_0;
		}
	}
}
