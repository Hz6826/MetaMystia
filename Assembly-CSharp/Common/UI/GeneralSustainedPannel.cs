using System;
using Common.UI.NoteBookUtility;
using Common.UI.StorageUtility;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Managers;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;

namespace Common.UI
{
	// Token: 0x0200037A RID: 890
	public class GeneralSustainedPannel : BaseSustainedPannel
	{
		// Token: 0x060069A0 RID: 27040 RVA: 0x001FEFC8 File Offset: 0x001FD1C8
		// Note: this type is marked as 'beforefieldinit'.
		static GeneralSustainedPannel()
		{
			Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "GeneralSustainedPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr);
			GeneralSustainedPannel.NativeFieldInfoPtr_m_CurrentActiveSustainedPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, "m_CurrentActiveSustainedPannel");
			GeneralSustainedPannel.NativeFieldInfoPtr_NoteBookPannelBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, "NoteBookPannelBtn");
			GeneralSustainedPannel.NativeFieldInfoPtr_StoragePannelBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, "StoragePannelBtn");
			GeneralSustainedPannel.NativeMethodInfoPtr_get_CurrentActiveSustainedPannel_Public_Static_get_GeneralSustainedPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, 100685204);
			GeneralSustainedPannel.NativeMethodInfoPtr_set_CurrentActiveSustainedPannel_Private_Static_set_Void_GeneralSustainedPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, 100685205);
			GeneralSustainedPannel.NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, 100685206);
			GeneralSustainedPannel.NativeMethodInfoPtr_OnPannelPostOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, 100685207);
			GeneralSustainedPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, 100685208);
			GeneralSustainedPannel.NativeMethodInfoPtr_OnSustainedPannelStatusChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, 100685209);
			GeneralSustainedPannel.NativeMethodInfoPtr_OnSustainedPannelStatusChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, 100685210);
			GeneralSustainedPannel.NativeMethodInfoPtr_OpenNoteBookPanelParameterless_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, 100685211);
			GeneralSustainedPannel.NativeMethodInfoPtr_OpenStoragePanelParameterless_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, 100685212);
			GeneralSustainedPannel.NativeMethodInfoPtr_OpenNoteBookPannel_Public_Void_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_1_UISubPanel_1_NoteBookMainPannel_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, 100685213);
			GeneralSustainedPannel.NativeMethodInfoPtr_OpenNoteBookPannelAsyncInternal_Private_UniTaskVoid_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_1_UISubPanel_1_NoteBookMainPannel_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, 100685214);
			GeneralSustainedPannel.NativeMethodInfoPtr_OpenStoragePannel_Public_Void_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, 100685215);
			GeneralSustainedPannel.NativeMethodInfoPtr_OpenStoragePannelAsyncInternal_Private_UniTaskVoid_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, 100685216);
			GeneralSustainedPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, 100685217);
			GeneralSustainedPannel.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, 100685218);
			GeneralSustainedPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__6_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, 100685219);
			GeneralSustainedPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__6_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, 100685220);
		}

		// Token: 0x1700242B RID: 9259
		// (get) Token: 0x060069A1 RID: 27041 RVA: 0x001FF188 File Offset: 0x001FD388
		// (set) Token: 0x060069A2 RID: 27042 RVA: 0x001FF1BC File Offset: 0x001FD3BC
		public unsafe static GeneralSustainedPannel CurrentActiveSustainedPannel
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 269460, RefRangeEnd = 269463, XrefRangeStart = 269453, XrefRangeEnd = 269460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralSustainedPannel.NativeMethodInfoPtr_get_CurrentActiveSustainedPannel_Public_Static_get_GeneralSustainedPannel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GeneralSustainedPannel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269463, XrefRangeEnd = 269467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralSustainedPannel.NativeMethodInfoPtr_set_CurrentActiveSustainedPannel_Private_Static_set_Void_GeneralSustainedPannel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060069A3 RID: 27043 RVA: 0x001FF1F4 File Offset: 0x001FD3F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269501, RefRangeEnd = 269502, XrefRangeStart = 269467, XrefRangeEnd = 269501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPannelPostInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneralSustainedPannel.NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A4 RID: 27044 RVA: 0x001FF230 File Offset: 0x001FD430
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269538, RefRangeEnd = 269540, XrefRangeStart = 269502, XrefRangeEnd = 269538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPannelPostOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneralSustainedPannel.NativeMethodInfoPtr_OnPannelPostOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A5 RID: 27045 RVA: 0x001FF26C File Offset: 0x001FD46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269540, XrefRangeEnd = 269572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneralSustainedPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A6 RID: 27046 RVA: 0x001FF2A8 File Offset: 0x001FD4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269572, XrefRangeEnd = 269573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSustainedPannelStatusChanged(bool _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralSustainedPannel.NativeMethodInfoPtr_OnSustainedPannelStatusChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A7 RID: 27047 RVA: 0x001FF2E8 File Offset: 0x001FD4E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269589, RefRangeEnd = 269591, XrefRangeStart = 269573, XrefRangeEnd = 269589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSustainedPannelStatusChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralSustainedPannel.NativeMethodInfoPtr_OnSustainedPannelStatusChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A8 RID: 27048 RVA: 0x001FF31C File Offset: 0x001FD51C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269593, RefRangeEnd = 269595, XrefRangeStart = 269591, XrefRangeEnd = 269593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenNoteBookPanelParameterless()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralSustainedPannel.NativeMethodInfoPtr_OpenNoteBookPanelParameterless_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A9 RID: 27049 RVA: 0x001FF350 File Offset: 0x001FD550
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74237, RefRangeEnd = 74239, XrefRangeStart = 74237, XrefRangeEnd = 74239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenStoragePanelParameterless()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralSustainedPannel.NativeMethodInfoPtr_OpenStoragePanelParameterless_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069AA RID: 27050 RVA: 0x001FF384 File Offset: 0x001FD584
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 269603, RefRangeEnd = 269608, XrefRangeStart = 269595, XrefRangeEnd = 269603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenNoteBookPannel(Nullable<NoteBookMainPannel.GoToSpecificType> overrideOpenType = null, Nullable<AdpUIPanelManager.PanelOpenMode> overrideOpenMode = null, Action<UISubPanel<NoteBookMainPannel>> preOpenPannelCallback = null, Action onPannelCloseCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideOpenType));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideOpenMode));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(preOpenPannelCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPannelCloseCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralSustainedPannel.NativeMethodInfoPtr_OpenNoteBookPannel_Public_Void_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_1_UISubPanel_1_NoteBookMainPannel_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069AB RID: 27051 RVA: 0x001FF408 File Offset: 0x001FD608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269608, XrefRangeEnd = 269615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OpenNoteBookPannelAsyncInternal(Nullable<NoteBookMainPannel.GoToSpecificType> overrideOpenType = null, Nullable<AdpUIPanelManager.PanelOpenMode> overrideOpenMode = null, Action<UISubPanel<NoteBookMainPannel>> preOpenPannelCallback = null, Action onPannelCloseCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideOpenType));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideOpenMode));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(preOpenPannelCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPannelCloseCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralSustainedPannel.NativeMethodInfoPtr_OpenNoteBookPannelAsyncInternal_Private_UniTaskVoid_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_1_UISubPanel_1_NoteBookMainPannel_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060069AC RID: 27052 RVA: 0x001FF498 File Offset: 0x001FD698
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269622, RefRangeEnd = 269624, XrefRangeStart = 269615, XrefRangeEnd = 269622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenStoragePannel(Nullable<StorageMainPannel.GoToSpecificType> overrideOpenType = null, Nullable<AdpUIPanelManager.PanelOpenMode> overrideOpenMode = null, Action onPannelCloseCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideOpenType));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideOpenMode));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPannelCloseCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralSustainedPannel.NativeMethodInfoPtr_OpenStoragePannel_Public_Void_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069AD RID: 27053 RVA: 0x001FF508 File Offset: 0x001FD708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269624, XrefRangeEnd = 269630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OpenStoragePannelAsyncInternal(Nullable<StorageMainPannel.GoToSpecificType> overrideOpenType = null, Nullable<AdpUIPanelManager.PanelOpenMode> overrideOpenMode = null, Action onPannelCloseCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideOpenType));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideOpenMode));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPannelCloseCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralSustainedPannel.NativeMethodInfoPtr_OpenStoragePannelAsyncInternal_Private_UniTaskVoid_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060069AE RID: 27054 RVA: 0x001FF584 File Offset: 0x001FD784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269630, XrefRangeEnd = 269641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GeneralSustainedPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069AF RID: 27055 RVA: 0x001FF5C0 File Offset: 0x001FD7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269641, XrefRangeEnd = 269642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeneralSustainedPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralSustainedPannel.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069B0 RID: 27056 RVA: 0x001FF5FC File Offset: 0x001FD7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269642, XrefRangeEnd = 269650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPannelPostInitialize_b__6_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralSustainedPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__6_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069B1 RID: 27057 RVA: 0x001FF630 File Offset: 0x001FD830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269650, XrefRangeEnd = 269657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPannelPostInitialize_b__6_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralSustainedPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__6_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069B2 RID: 27058 RVA: 0x0003920A File Offset: 0x0003740A
		public GeneralSustainedPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002428 RID: 9256
		// (get) Token: 0x060069B3 RID: 27059 RVA: 0x001FF664 File Offset: 0x001FD864
		// (set) Token: 0x060069B4 RID: 27060 RVA: 0x00039213 File Offset: 0x00037413
		public unsafe static GeneralSustainedPannel m_CurrentActiveSustainedPannel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GeneralSustainedPannel.NativeFieldInfoPtr_m_CurrentActiveSustainedPannel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GeneralSustainedPannel>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GeneralSustainedPannel.NativeFieldInfoPtr_m_CurrentActiveSustainedPannel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002429 RID: 9257
		// (get) Token: 0x060069B5 RID: 27061 RVA: 0x001FF68C File Offset: 0x001FD88C
		// (set) Token: 0x060069B6 RID: 27062 RVA: 0x00039225 File Offset: 0x00037425
		public unsafe UIButtonSimple NoteBookPannelBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel.NativeFieldInfoPtr_NoteBookPannelBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel.NativeFieldInfoPtr_NoteBookPannelBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242A RID: 9258
		// (get) Token: 0x060069B7 RID: 27063 RVA: 0x001FF6BC File Offset: 0x001FD8BC
		// (set) Token: 0x060069B8 RID: 27064 RVA: 0x00039244 File Offset: 0x00037444
		public unsafe UIButtonSimple StoragePannelBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel.NativeFieldInfoPtr_StoragePannelBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel.NativeFieldInfoPtr_StoragePannelBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400460A RID: 17930
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentActiveSustainedPannel;

		// Token: 0x0400460B RID: 17931
		private static readonly IntPtr NativeFieldInfoPtr_NoteBookPannelBtn;

		// Token: 0x0400460C RID: 17932
		private static readonly IntPtr NativeFieldInfoPtr_StoragePannelBtn;

		// Token: 0x0400460D RID: 17933
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentActiveSustainedPannel_Public_Static_get_GeneralSustainedPannel_0;

		// Token: 0x0400460E RID: 17934
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentActiveSustainedPannel_Private_Static_set_Void_GeneralSustainedPannel_0;

		// Token: 0x0400460F RID: 17935
		private static readonly IntPtr NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004610 RID: 17936
		private static readonly IntPtr NativeMethodInfoPtr_OnPannelPostOpen_Protected_Virtual_Void_0;

		// Token: 0x04004611 RID: 17937
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04004612 RID: 17938
		private static readonly IntPtr NativeMethodInfoPtr_OnSustainedPannelStatusChanged_Private_Void_Boolean_0;

		// Token: 0x04004613 RID: 17939
		private static readonly IntPtr NativeMethodInfoPtr_OnSustainedPannelStatusChanged_Private_Void_0;

		// Token: 0x04004614 RID: 17940
		private static readonly IntPtr NativeMethodInfoPtr_OpenNoteBookPanelParameterless_Public_Void_0;

		// Token: 0x04004615 RID: 17941
		private static readonly IntPtr NativeMethodInfoPtr_OpenStoragePanelParameterless_Public_Void_0;

		// Token: 0x04004616 RID: 17942
		private static readonly IntPtr NativeMethodInfoPtr_OpenNoteBookPannel_Public_Void_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_1_UISubPanel_1_NoteBookMainPannel_Action_0;

		// Token: 0x04004617 RID: 17943
		private static readonly IntPtr NativeMethodInfoPtr_OpenNoteBookPannelAsyncInternal_Private_UniTaskVoid_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_1_UISubPanel_1_NoteBookMainPannel_Action_0;

		// Token: 0x04004618 RID: 17944
		private static readonly IntPtr NativeMethodInfoPtr_OpenStoragePannel_Public_Void_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_0;

		// Token: 0x04004619 RID: 17945
		private static readonly IntPtr NativeMethodInfoPtr_OpenStoragePannelAsyncInternal_Private_UniTaskVoid_Nullable_1_GoToSpecificType_Nullable_1_PanelOpenMode_Action_0;

		// Token: 0x0400461A RID: 17946
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400461B RID: 17947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400461C RID: 17948
		private static readonly IntPtr NativeMethodInfoPtr__OnPannelPostInitialize_b__6_0_Private_Void_0;

		// Token: 0x0400461D RID: 17949
		private static readonly IntPtr NativeMethodInfoPtr__OnPannelPostInitialize_b__6_1_Private_Void_0;

		// Token: 0x02000E88 RID: 3720
		[ObfuscatedName("Common.UI.GeneralSustainedPannel+<OpenNoteBookPannelAsyncInternal>d__14")]
		public sealed class _OpenNoteBookPannelAsyncInternal_d__14 : ValueType
		{
			// Token: 0x060107F5 RID: 67573 RVA: 0x003D3A14 File Offset: 0x003D1C14
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenNoteBookPannelAsyncInternal_d__14()
			{
				Il2CppClassPointerStore<GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, "<OpenNoteBookPannelAsyncInternal>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14>.NativeClassPtr);
				GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14>.NativeClassPtr, "<>1__state");
				GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14>.NativeClassPtr, "<>t__builder");
				GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14>.NativeClassPtr, "<>4__this");
				GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr_onPannelCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14>.NativeClassPtr, "onPannelCloseCallback");
				GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr_overrideOpenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14>.NativeClassPtr, "overrideOpenType");
				GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr_preOpenPannelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14>.NativeClassPtr, "preOpenPannelCallback");
				GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr_overrideOpenMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14>.NativeClassPtr, "overrideOpenMode");
				GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14>.NativeClassPtr, "<>u__1");
				GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14>.NativeClassPtr, 100685221);
				GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14>.NativeClassPtr, 100685222);
			}

			// Token: 0x060107F6 RID: 67574 RVA: 0x003D3B08 File Offset: 0x003D1D08
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 269399, RefRangeEnd = 269401, XrefRangeStart = 269346, XrefRangeEnd = 269399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107F7 RID: 67575 RVA: 0x003D3B40 File Offset: 0x003D1D40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060107F8 RID: 67576 RVA: 0x0008FF46 File Offset: 0x0008E146
			public _OpenNoteBookPannelAsyncInternal_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060107F9 RID: 67577 RVA: 0x0008FF4F File Offset: 0x0008E14F
			public _OpenNoteBookPannelAsyncInternal_d__14() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14>.NativeClassPtr))
			{
			}

			// Token: 0x1700561E RID: 22046
			// (get) Token: 0x060107FA RID: 67578 RVA: 0x003D3B88 File Offset: 0x003D1D88
			// (set) Token: 0x060107FB RID: 67579 RVA: 0x0008FF61 File Offset: 0x0008E161
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700561F RID: 22047
			// (get) Token: 0x060107FC RID: 67580 RVA: 0x003D3BB0 File Offset: 0x003D1DB0
			// (set) Token: 0x060107FD RID: 67581 RVA: 0x0008FF7C File Offset: 0x0008E17C
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005620 RID: 22048
			// (get) Token: 0x060107FE RID: 67582 RVA: 0x003D3BE0 File Offset: 0x003D1DE0
			// (set) Token: 0x060107FF RID: 67583 RVA: 0x0008FFAA File Offset: 0x0008E1AA
			public unsafe GeneralSustainedPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GeneralSustainedPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005621 RID: 22049
			// (get) Token: 0x06010800 RID: 67584 RVA: 0x003D3C10 File Offset: 0x003D1E10
			// (set) Token: 0x06010801 RID: 67585 RVA: 0x0008FFC9 File Offset: 0x0008E1C9
			public unsafe Action onPannelCloseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr_onPannelCloseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr_onPannelCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005622 RID: 22050
			// (get) Token: 0x06010802 RID: 67586 RVA: 0x003D3C40 File Offset: 0x003D1E40
			// (set) Token: 0x06010803 RID: 67587 RVA: 0x0008FFE8 File Offset: 0x0008E1E8
			public Nullable<NoteBookMainPannel.GoToSpecificType> overrideOpenType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr_overrideOpenType);
					return new Nullable<NoteBookMainPannel.GoToSpecificType>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<NoteBookMainPannel.GoToSpecificType>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr_overrideOpenType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<NoteBookMainPannel.GoToSpecificType>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005623 RID: 22051
			// (get) Token: 0x06010804 RID: 67588 RVA: 0x003D3C70 File Offset: 0x003D1E70
			// (set) Token: 0x06010805 RID: 67589 RVA: 0x00090016 File Offset: 0x0008E216
			public unsafe Action<UISubPanel<NoteBookMainPannel>> preOpenPannelCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr_preOpenPannelCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UISubPanel<NoteBookMainPannel>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr_preOpenPannelCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005624 RID: 22052
			// (get) Token: 0x06010806 RID: 67590 RVA: 0x003D3CA0 File Offset: 0x003D1EA0
			// (set) Token: 0x06010807 RID: 67591 RVA: 0x00090035 File Offset: 0x0008E235
			public Nullable<AdpUIPanelManager.PanelOpenMode> overrideOpenMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr_overrideOpenMode);
					return new Nullable<AdpUIPanelManager.PanelOpenMode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<AdpUIPanelManager.PanelOpenMode>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr_overrideOpenMode), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<AdpUIPanelManager.PanelOpenMode>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005625 RID: 22053
			// (get) Token: 0x06010808 RID: 67592 RVA: 0x003D3CD0 File Offset: 0x003D1ED0
			// (set) Token: 0x06010809 RID: 67593 RVA: 0x00090063 File Offset: 0x0008E263
			public UniTask<NoteBookMainPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr___u__1);
					return new UniTask<NoteBookMainPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<NoteBookMainPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenNoteBookPannelAsyncInternal_d__14.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<NoteBookMainPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A704 RID: 42756
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A705 RID: 42757
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A706 RID: 42758
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A707 RID: 42759
			private static readonly IntPtr NativeFieldInfoPtr_onPannelCloseCallback;

			// Token: 0x0400A708 RID: 42760
			private static readonly IntPtr NativeFieldInfoPtr_overrideOpenType;

			// Token: 0x0400A709 RID: 42761
			private static readonly IntPtr NativeFieldInfoPtr_preOpenPannelCallback;

			// Token: 0x0400A70A RID: 42762
			private static readonly IntPtr NativeFieldInfoPtr_overrideOpenMode;

			// Token: 0x0400A70B RID: 42763
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A70C RID: 42764
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A70D RID: 42765
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000E89 RID: 3721
		[ObfuscatedName("Common.UI.GeneralSustainedPannel+<OpenStoragePannelAsyncInternal>d__16")]
		public sealed class _OpenStoragePannelAsyncInternal_d__16 : ValueType
		{
			// Token: 0x0601080A RID: 67594 RVA: 0x003D3D00 File Offset: 0x003D1F00
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenStoragePannelAsyncInternal_d__16()
			{
				Il2CppClassPointerStore<GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GeneralSustainedPannel>.NativeClassPtr, "<OpenStoragePannelAsyncInternal>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16>.NativeClassPtr);
				GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16>.NativeClassPtr, "<>1__state");
				GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16>.NativeClassPtr, "<>t__builder");
				GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16>.NativeClassPtr, "<>4__this");
				GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr_onPannelCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16>.NativeClassPtr, "onPannelCloseCallback");
				GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr_overrideOpenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16>.NativeClassPtr, "overrideOpenType");
				GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr_overrideOpenMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16>.NativeClassPtr, "overrideOpenMode");
				GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16>.NativeClassPtr, "<>u__1");
				GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16>.NativeClassPtr, 100685223);
				GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16>.NativeClassPtr, 100685224);
			}

			// Token: 0x0601080B RID: 67595 RVA: 0x003D3DE0 File Offset: 0x003D1FE0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 269451, RefRangeEnd = 269453, XrefRangeStart = 269401, XrefRangeEnd = 269451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601080C RID: 67596 RVA: 0x003D3E18 File Offset: 0x003D2018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601080D RID: 67597 RVA: 0x00090091 File Offset: 0x0008E291
			public _OpenStoragePannelAsyncInternal_d__16(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0601080E RID: 67598 RVA: 0x0009009A File Offset: 0x0008E29A
			public _OpenStoragePannelAsyncInternal_d__16() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16>.NativeClassPtr))
			{
			}

			// Token: 0x17005626 RID: 22054
			// (get) Token: 0x0601080F RID: 67599 RVA: 0x003D3E60 File Offset: 0x003D2060
			// (set) Token: 0x06010810 RID: 67600 RVA: 0x000900AC File Offset: 0x0008E2AC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005627 RID: 22055
			// (get) Token: 0x06010811 RID: 67601 RVA: 0x003D3E88 File Offset: 0x003D2088
			// (set) Token: 0x06010812 RID: 67602 RVA: 0x000900C7 File Offset: 0x0008E2C7
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005628 RID: 22056
			// (get) Token: 0x06010813 RID: 67603 RVA: 0x003D3EB8 File Offset: 0x003D20B8
			// (set) Token: 0x06010814 RID: 67604 RVA: 0x000900F5 File Offset: 0x0008E2F5
			public unsafe GeneralSustainedPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GeneralSustainedPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005629 RID: 22057
			// (get) Token: 0x06010815 RID: 67605 RVA: 0x003D3EE8 File Offset: 0x003D20E8
			// (set) Token: 0x06010816 RID: 67606 RVA: 0x00090114 File Offset: 0x0008E314
			public unsafe Action onPannelCloseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr_onPannelCloseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr_onPannelCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700562A RID: 22058
			// (get) Token: 0x06010817 RID: 67607 RVA: 0x003D3F18 File Offset: 0x003D2118
			// (set) Token: 0x06010818 RID: 67608 RVA: 0x00090133 File Offset: 0x0008E333
			public Nullable<StorageMainPannel.GoToSpecificType> overrideOpenType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr_overrideOpenType);
					return new Nullable<StorageMainPannel.GoToSpecificType>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<StorageMainPannel.GoToSpecificType>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr_overrideOpenType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<StorageMainPannel.GoToSpecificType>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700562B RID: 22059
			// (get) Token: 0x06010819 RID: 67609 RVA: 0x003D3F48 File Offset: 0x003D2148
			// (set) Token: 0x0601081A RID: 67610 RVA: 0x00090161 File Offset: 0x0008E361
			public Nullable<AdpUIPanelManager.PanelOpenMode> overrideOpenMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr_overrideOpenMode);
					return new Nullable<AdpUIPanelManager.PanelOpenMode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<AdpUIPanelManager.PanelOpenMode>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr_overrideOpenMode), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<AdpUIPanelManager.PanelOpenMode>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700562C RID: 22060
			// (get) Token: 0x0601081B RID: 67611 RVA: 0x003D3F78 File Offset: 0x003D2178
			// (set) Token: 0x0601081C RID: 67612 RVA: 0x0009018F File Offset: 0x0008E38F
			public UniTask<StorageMainPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr___u__1);
					return new UniTask<StorageMainPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<StorageMainPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneralSustainedPannel._OpenStoragePannelAsyncInternal_d__16.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<StorageMainPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A70E RID: 42766
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A70F RID: 42767
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A710 RID: 42768
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A711 RID: 42769
			private static readonly IntPtr NativeFieldInfoPtr_onPannelCloseCallback;

			// Token: 0x0400A712 RID: 42770
			private static readonly IntPtr NativeFieldInfoPtr_overrideOpenType;

			// Token: 0x0400A713 RID: 42771
			private static readonly IntPtr NativeFieldInfoPtr_overrideOpenMode;

			// Token: 0x0400A714 RID: 42772
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A715 RID: 42773
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A716 RID: 42774
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
