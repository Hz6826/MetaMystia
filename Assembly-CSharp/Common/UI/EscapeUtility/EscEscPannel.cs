using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Common.UI.EscapeUtility
{
	// Token: 0x020003BE RID: 958
	public class EscEscPannel : UISubPanel<EscMainPannel>
	{
		// Token: 0x06007258 RID: 29272 RVA: 0x0021BCC8 File Offset: 0x00219EC8
		// Note: this type is marked as 'beforefieldinit'.
		static EscEscPannel()
		{
			Il2CppClassPointerStore<EscEscPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.EscapeUtility", "EscEscPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscEscPannel>.NativeClassPtr);
			EscEscPannel.NativeFieldInfoPtr_BackToMainMenuBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscEscPannel>.NativeClassPtr, "BackToMainMenuBtn");
			EscEscPannel.NativeFieldInfoPtr_CloseGameBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscEscPannel>.NativeClassPtr, "CloseGameBtn");
			EscEscPannel.NativeFieldInfoPtr_m_ShouldInstantClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscEscPannel>.NativeClassPtr, "m_ShouldInstantClose");
			EscEscPannel.NativeFieldInfoPtr__CloseData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscEscPannel>.NativeClassPtr, "<CloseData>k__BackingField");
			EscEscPannel.NativeMethodInfoPtr_get_CloseData_Public_get_CloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscEscPannel>.NativeClassPtr, 100686854);
			EscEscPannel.NativeMethodInfoPtr_set_CloseData_Private_set_Void_CloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscEscPannel>.NativeClassPtr, 100686855);
			EscEscPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscEscPannel>.NativeClassPtr, 100686856);
			EscEscPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscEscPannel>.NativeClassPtr, 100686857);
			EscEscPannel.NativeMethodInfoPtr_OnSubmit_Private_Void_CloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscEscPannel>.NativeClassPtr, 100686858);
			EscEscPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscEscPannel>.NativeClassPtr, 100686859);
			EscEscPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscEscPannel>.NativeClassPtr, 100686860);
			EscEscPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscEscPannel>.NativeClassPtr, 100686861);
			EscEscPannel.NativeMethodInfoPtr__OnPanelInitialize_b__9_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscEscPannel>.NativeClassPtr, 100686862);
			EscEscPannel.NativeMethodInfoPtr__OnPanelInitialize_b__9_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscEscPannel>.NativeClassPtr, 100686863);
		}

		// Token: 0x1700272E RID: 10030
		// (get) Token: 0x06007259 RID: 29273 RVA: 0x0021BE10 File Offset: 0x0021A010
		// (set) Token: 0x0600725A RID: 29274 RVA: 0x0021BE4C File Offset: 0x0021A04C
		public unsafe EscEscPannel.CloseContext CloseData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscEscPannel.NativeMethodInfoPtr_get_CloseData_Public_get_CloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 166417, RefRangeEnd = 166418, XrefRangeStart = 166417, XrefRangeEnd = 166418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscEscPannel.NativeMethodInfoPtr_set_CloseData_Private_set_Void_CloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600725B RID: 29275 RVA: 0x0021BE8C File Offset: 0x0021A08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285586, XrefRangeEnd = 285587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscEscPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600725C RID: 29276 RVA: 0x0021BED4 File Offset: 0x0021A0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285587, XrefRangeEnd = 285605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscEscPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600725D RID: 29277 RVA: 0x0021BF10 File Offset: 0x0021A110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285605, XrefRangeEnd = 285610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSubmit(EscEscPannel.CloseContext closeContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref closeContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscEscPannel.NativeMethodInfoPtr_OnSubmit_Private_Void_CloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600725E RID: 29278 RVA: 0x0021BF50 File Offset: 0x0021A150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285610, XrefRangeEnd = 285611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscEscPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600725F RID: 29279 RVA: 0x0021BF8C File Offset: 0x0021A18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscEscPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007260 RID: 29280 RVA: 0x0021BFC8 File Offset: 0x0021A1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285611, XrefRangeEnd = 285614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EscEscPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscEscPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscEscPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007261 RID: 29281 RVA: 0x0021C004 File Offset: 0x0021A204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285614, XrefRangeEnd = 285617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__9_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscEscPannel.NativeMethodInfoPtr__OnPanelInitialize_b__9_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007262 RID: 29282 RVA: 0x0021C038 File Offset: 0x0021A238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285617, XrefRangeEnd = 285620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__9_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscEscPannel.NativeMethodInfoPtr__OnPanelInitialize_b__9_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007263 RID: 29283 RVA: 0x0003DDE7 File Offset: 0x0003BFE7
		public EscEscPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700272A RID: 10026
		// (get) Token: 0x06007264 RID: 29284 RVA: 0x0021C06C File Offset: 0x0021A26C
		// (set) Token: 0x06007265 RID: 29285 RVA: 0x0003DDF0 File Offset: 0x0003BFF0
		public unsafe UIButtonHold BackToMainMenuBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscEscPannel.NativeFieldInfoPtr_BackToMainMenuBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscEscPannel.NativeFieldInfoPtr_BackToMainMenuBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700272B RID: 10027
		// (get) Token: 0x06007266 RID: 29286 RVA: 0x0021C09C File Offset: 0x0021A29C
		// (set) Token: 0x06007267 RID: 29287 RVA: 0x0003DE0F File Offset: 0x0003C00F
		public unsafe UIButtonHold CloseGameBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscEscPannel.NativeFieldInfoPtr_CloseGameBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscEscPannel.NativeFieldInfoPtr_CloseGameBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700272C RID: 10028
		// (get) Token: 0x06007268 RID: 29288 RVA: 0x0021C0CC File Offset: 0x0021A2CC
		// (set) Token: 0x06007269 RID: 29289 RVA: 0x0003DE2E File Offset: 0x0003C02E
		public unsafe bool m_ShouldInstantClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscEscPannel.NativeFieldInfoPtr_m_ShouldInstantClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscEscPannel.NativeFieldInfoPtr_m_ShouldInstantClose)) = value;
			}
		}

		// Token: 0x1700272D RID: 10029
		// (get) Token: 0x0600726A RID: 29290 RVA: 0x0021C0F4 File Offset: 0x0021A2F4
		// (set) Token: 0x0600726B RID: 29291 RVA: 0x0003DE49 File Offset: 0x0003C049
		public unsafe EscEscPannel.CloseContext _CloseData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscEscPannel.NativeFieldInfoPtr__CloseData_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscEscPannel.NativeFieldInfoPtr__CloseData_k__BackingField)) = value;
			}
		}

		// Token: 0x04004BCA RID: 19402
		private static readonly IntPtr NativeFieldInfoPtr_BackToMainMenuBtn;

		// Token: 0x04004BCB RID: 19403
		private static readonly IntPtr NativeFieldInfoPtr_CloseGameBtn;

		// Token: 0x04004BCC RID: 19404
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldInstantClose;

		// Token: 0x04004BCD RID: 19405
		private static readonly IntPtr NativeFieldInfoPtr__CloseData_k__BackingField;

		// Token: 0x04004BCE RID: 19406
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseData_Public_get_CloseContext_0;

		// Token: 0x04004BCF RID: 19407
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseData_Private_set_Void_CloseContext_0;

		// Token: 0x04004BD0 RID: 19408
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x04004BD1 RID: 19409
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004BD2 RID: 19410
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Private_Void_CloseContext_0;

		// Token: 0x04004BD3 RID: 19411
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004BD4 RID: 19412
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004BD5 RID: 19413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004BD6 RID: 19414
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_0_Private_Void_0;

		// Token: 0x04004BD7 RID: 19415
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_1_Private_Void_0;

		// Token: 0x02000F37 RID: 3895
		public enum CloseContext
		{
			// Token: 0x0400ABF7 RID: 44023
			BackToMainMenu,
			// Token: 0x0400ABF8 RID: 44024
			CloseGame,
			// Token: 0x0400ABF9 RID: 44025
			None
		}
	}
}
