using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Common.UI.EscapeUtility
{
	// Token: 0x020003C0 RID: 960
	public class EscLoadPannelSubPannel : UISubPanel<EscLoadPannel>
	{
		// Token: 0x06007294 RID: 29332 RVA: 0x0021C9D4 File Offset: 0x0021ABD4
		// Note: this type is marked as 'beforefieldinit'.
		static EscLoadPannelSubPannel()
		{
			Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.EscapeUtility", "EscLoadPannelSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr);
			EscLoadPannelSubPannel.NativeFieldInfoPtr_LoadBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, "LoadBtn");
			EscLoadPannelSubPannel.NativeFieldInfoPtr_DeleteBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, "DeleteBtn");
			EscLoadPannelSubPannel.NativeFieldInfoPtr_BackBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, "BackBtn");
			EscLoadPannelSubPannel.NativeFieldInfoPtr_SubPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, "SubPannel");
			EscLoadPannelSubPannel.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, "Result");
			EscLoadPannelSubPannel.NativeFieldInfoPtr__SubPanelDisplayedContent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, "<SubPanelDisplayedContent>k__BackingField");
			EscLoadPannelSubPannel.NativeFieldInfoPtr_m_AllBtns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, "m_AllBtns");
			EscLoadPannelSubPannel.NativeFieldInfoPtr_m_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, "m_Result");
			EscLoadPannelSubPannel.NativeFieldInfoPtr_m_ShouldInstantClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, "m_ShouldInstantClose");
			EscLoadPannelSubPannel.NativeMethodInfoPtr_get_SubPanelDisplayedContent_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, 100686909);
			EscLoadPannelSubPannel.NativeMethodInfoPtr_set_SubPanelDisplayedContent_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, 100686910);
			EscLoadPannelSubPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, 100686911);
			EscLoadPannelSubPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, 100686912);
			EscLoadPannelSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, 100686913);
			EscLoadPannelSubPannel.NativeMethodInfoPtr_PopupConfirmationMenu_Private_Void_String_PannelResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, 100686914);
			EscLoadPannelSubPannel.NativeMethodInfoPtr_OnSubPannelExit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, 100686915);
			EscLoadPannelSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, 100686916);
			EscLoadPannelSubPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, 100686917);
			EscLoadPannelSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, 100686918);
			EscLoadPannelSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, 100686919);
			EscLoadPannelSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__16_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, 100686920);
			EscLoadPannelSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__16_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr, 100686921);
		}

		// Token: 0x17002744 RID: 10052
		// (get) Token: 0x06007295 RID: 29333 RVA: 0x0021CBBC File Offset: 0x0021ADBC
		// (set) Token: 0x06007296 RID: 29334 RVA: 0x0021CBF4 File Offset: 0x0021ADF4
		public unsafe string SubPanelDisplayedContent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22275, RefRangeEnd = 22276, XrefRangeStart = 22275, XrefRangeEnd = 22276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannelSubPannel.NativeMethodInfoPtr_get_SubPanelDisplayedContent_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannelSubPannel.NativeMethodInfoPtr_set_SubPanelDisplayedContent_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002745 RID: 10053
		// (get) Token: 0x06007297 RID: 29335 RVA: 0x0021CC38 File Offset: 0x0021AE38
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscLoadPannelSubPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007298 RID: 29336 RVA: 0x0021CC80 File Offset: 0x0021AE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286880, XrefRangeEnd = 286881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscLoadPannelSubPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007299 RID: 29337 RVA: 0x0021CCC8 File Offset: 0x0021AEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286881, XrefRangeEnd = 286926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscLoadPannelSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600729A RID: 29338 RVA: 0x0021CD04 File Offset: 0x0021AF04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286941, RefRangeEnd = 286943, XrefRangeStart = 286926, XrefRangeEnd = 286941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopupConfirmationMenu(string displayedContentKey, EscLoadPannelSubPannel.PannelResult confirmationTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(displayedContentKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confirmationTarget;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannelSubPannel.NativeMethodInfoPtr_PopupConfirmationMenu_Private_Void_String_PannelResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600729B RID: 29339 RVA: 0x0021CD54 File Offset: 0x0021AF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286943, XrefRangeEnd = 286952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSubPannelExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannelSubPannel.NativeMethodInfoPtr_OnSubPannelExit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600729C RID: 29340 RVA: 0x0021CD88 File Offset: 0x0021AF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286952, XrefRangeEnd = 286956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscLoadPannelSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600729D RID: 29341 RVA: 0x0021CDC4 File Offset: 0x0021AFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286956, XrefRangeEnd = 286962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscLoadPannelSubPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600729E RID: 29342 RVA: 0x0021CE00 File Offset: 0x0021B000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286962, XrefRangeEnd = 286969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscLoadPannelSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600729F RID: 29343 RVA: 0x0021CE3C File Offset: 0x0021B03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286969, XrefRangeEnd = 286972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EscLoadPannelSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscLoadPannelSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannelSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072A0 RID: 29344 RVA: 0x0021CE78 File Offset: 0x0021B078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286972, XrefRangeEnd = 286986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__16_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannelSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__16_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072A1 RID: 29345 RVA: 0x0021CEAC File Offset: 0x0021B0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286986, XrefRangeEnd = 286990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__16_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannelSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__16_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072A2 RID: 29346 RVA: 0x0003DFAD File Offset: 0x0003C1AD
		public EscLoadPannelSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700273B RID: 10043
		// (get) Token: 0x060072A3 RID: 29347 RVA: 0x0021CEE0 File Offset: 0x0021B0E0
		// (set) Token: 0x060072A4 RID: 29348 RVA: 0x0003DFB6 File Offset: 0x0003C1B6
		public unsafe UIButtonSimple LoadBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr_LoadBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr_LoadBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700273C RID: 10044
		// (get) Token: 0x060072A5 RID: 29349 RVA: 0x0021CF10 File Offset: 0x0021B110
		// (set) Token: 0x060072A6 RID: 29350 RVA: 0x0003DFD5 File Offset: 0x0003C1D5
		public unsafe UIButtonSimple DeleteBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr_DeleteBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr_DeleteBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700273D RID: 10045
		// (get) Token: 0x060072A7 RID: 29351 RVA: 0x0021CF40 File Offset: 0x0021B140
		// (set) Token: 0x060072A8 RID: 29352 RVA: 0x0003DFF4 File Offset: 0x0003C1F4
		public unsafe UIButtonSimple BackBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr_BackBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr_BackBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700273E RID: 10046
		// (get) Token: 0x060072A9 RID: 29353 RVA: 0x0021CF70 File Offset: 0x0021B170
		// (set) Token: 0x060072AA RID: 29354 RVA: 0x0003E013 File Offset: 0x0003C213
		public unsafe EscLoadPannelSubSubPannel SubPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr_SubPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannelSubSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr_SubPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700273F RID: 10047
		// (get) Token: 0x060072AB RID: 29355 RVA: 0x0021CFA0 File Offset: 0x0021B1A0
		// (set) Token: 0x060072AC RID: 29356 RVA: 0x0003E032 File Offset: 0x0003C232
		public unsafe EscLoadPannelSubPannel.PannelResult Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x17002740 RID: 10048
		// (get) Token: 0x060072AD RID: 29357 RVA: 0x0021CFC8 File Offset: 0x0021B1C8
		// (set) Token: 0x060072AE RID: 29358 RVA: 0x0003E04D File Offset: 0x0003C24D
		public unsafe string _SubPanelDisplayedContent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr__SubPanelDisplayedContent_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr__SubPanelDisplayedContent_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002741 RID: 10049
		// (get) Token: 0x060072AF RID: 29359 RVA: 0x0021CFF0 File Offset: 0x0021B1F0
		// (set) Token: 0x060072B0 RID: 29360 RVA: 0x0003E06C File Offset: 0x0003C26C
		public unsafe UILogicalGroup m_AllBtns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr_m_AllBtns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr_m_AllBtns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002742 RID: 10050
		// (get) Token: 0x060072B1 RID: 29361 RVA: 0x0021D020 File Offset: 0x0021B220
		// (set) Token: 0x060072B2 RID: 29362 RVA: 0x0003E08B File Offset: 0x0003C28B
		public unsafe EscLoadPannelSubPannel.PannelResult m_Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr_m_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr_m_Result)) = value;
			}
		}

		// Token: 0x17002743 RID: 10051
		// (get) Token: 0x060072B3 RID: 29363 RVA: 0x0021D048 File Offset: 0x0021B248
		// (set) Token: 0x060072B4 RID: 29364 RVA: 0x0003E0A6 File Offset: 0x0003C2A6
		public unsafe bool m_ShouldInstantClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr_m_ShouldInstantClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubPannel.NativeFieldInfoPtr_m_ShouldInstantClose)) = value;
			}
		}

		// Token: 0x04004BF3 RID: 19443
		private static readonly IntPtr NativeFieldInfoPtr_LoadBtn;

		// Token: 0x04004BF4 RID: 19444
		private static readonly IntPtr NativeFieldInfoPtr_DeleteBtn;

		// Token: 0x04004BF5 RID: 19445
		private static readonly IntPtr NativeFieldInfoPtr_BackBtn;

		// Token: 0x04004BF6 RID: 19446
		private static readonly IntPtr NativeFieldInfoPtr_SubPannel;

		// Token: 0x04004BF7 RID: 19447
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04004BF8 RID: 19448
		private static readonly IntPtr NativeFieldInfoPtr__SubPanelDisplayedContent_k__BackingField;

		// Token: 0x04004BF9 RID: 19449
		private static readonly IntPtr NativeFieldInfoPtr_m_AllBtns;

		// Token: 0x04004BFA RID: 19450
		private static readonly IntPtr NativeFieldInfoPtr_m_Result;

		// Token: 0x04004BFB RID: 19451
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldInstantClose;

		// Token: 0x04004BFC RID: 19452
		private static readonly IntPtr NativeMethodInfoPtr_get_SubPanelDisplayedContent_Private_get_String_0;

		// Token: 0x04004BFD RID: 19453
		private static readonly IntPtr NativeMethodInfoPtr_set_SubPanelDisplayedContent_Public_set_Void_String_0;

		// Token: 0x04004BFE RID: 19454
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04004BFF RID: 19455
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x04004C00 RID: 19456
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004C01 RID: 19457
		private static readonly IntPtr NativeMethodInfoPtr_PopupConfirmationMenu_Private_Void_String_PannelResult_0;

		// Token: 0x04004C02 RID: 19458
		private static readonly IntPtr NativeMethodInfoPtr_OnSubPannelExit_Private_Void_0;

		// Token: 0x04004C03 RID: 19459
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004C04 RID: 19460
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04004C05 RID: 19461
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004C06 RID: 19462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004C07 RID: 19463
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__16_0_Private_Void_0;

		// Token: 0x04004C08 RID: 19464
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__16_1_Private_Void_0;

		// Token: 0x02000F41 RID: 3905
		public enum PannelResult
		{
			// Token: 0x0400AC43 RID: 44099
			GameLoaded,
			// Token: 0x0400AC44 RID: 44100
			SaveDeleted,
			// Token: 0x0400AC45 RID: 44101
			None
		}
	}
}
