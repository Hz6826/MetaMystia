using System;
using Common.UI;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection.Async;
using DEYU.AssetHandleUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine.AddressableAssets;
using UnityEngine.InputSystem;

namespace MusicGame.UI
{
	// Token: 0x0200001B RID: 27
	public class MusicGameIntroInfoPannel : AsyncUIPanel
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x000A5548 File Offset: 0x000A3748
		// Note: this type is marked as 'beforefieldinit'.
		static MusicGameIntroInfoPannel()
		{
			Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "MusicGameIntroInfoPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr);
			MusicGameIntroInfoPannel.NativeFieldInfoPtr_EXIT_MUSICGAME_WARNING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, "EXIT_MUSICGAME_WARNING");
			MusicGameIntroInfoPannel.NativeFieldInfoPtr_startButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, "startButton");
			MusicGameIntroInfoPannel.NativeFieldInfoPtr_endButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, "endButton");
			MusicGameIntroInfoPannel.NativeFieldInfoPtr_customButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, "customButton");
			MusicGameIntroInfoPannel.NativeFieldInfoPtr_mapSelectPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, "mapSelectPannel");
			MusicGameIntroInfoPannel.NativeFieldInfoPtr_MusicGameMenuBGMPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, "MusicGameMenuBGMPackage");
			MusicGameIntroInfoPannel.NativeFieldInfoPtr_DialogBoxPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, "DialogBoxPannel");
			MusicGameIntroInfoPannel.NativeFieldInfoPtr_m_BootstrapPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, "m_BootstrapPanel");
			MusicGameIntroInfoPannel.NativeFieldInfoPtr_m_LastPlayingBGMPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, "m_LastPlayingBGMPackage");
			MusicGameIntroInfoPannel.NativeFieldInfoPtr_m_LoadedBGMHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, "m_LoadedBGMHandle");
			MusicGameIntroInfoPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, 100663570);
			MusicGameIntroInfoPannel.NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, 100663571);
			MusicGameIntroInfoPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, 100663572);
			MusicGameIntroInfoPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, 100663573);
			MusicGameIntroInfoPannel.NativeMethodInfoPtr_OnWillClose_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, 100663574);
			MusicGameIntroInfoPannel.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, 100663575);
			MusicGameIntroInfoPannel.NativeMethodInfoPtr_GotoSelectorPannel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, 100663576);
			MusicGameIntroInfoPannel.NativeMethodInfoPtr_OnFadeFinish_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, 100663577);
			MusicGameIntroInfoPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, 100663578);
			MusicGameIntroInfoPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, 100663579);
			MusicGameIntroInfoPannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, 100663580);
			MusicGameIntroInfoPannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, 100663581);
			MusicGameIntroInfoPannel.NativeMethodInfoPtr__OnClose_b__15_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, 100663582);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000A5744 File Offset: 0x000A3944
		[CallerCount(0)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameIntroInfoPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x000A578C File Offset: 0x000A398C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19286, XrefRangeEnd = 19291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override UniTaskVoid OnPanelOpenAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameIntroInfoPannel.NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000A57D4 File Offset: 0x000A39D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19291, XrefRangeEnd = 19301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameIntroInfoPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000A5810 File Offset: 0x000A3A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19301, XrefRangeEnd = 19329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameIntroInfoPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000A584C File Offset: 0x000A3A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19329, XrefRangeEnd = 19348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillClose(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameIntroInfoPannel.NativeMethodInfoPtr_OnWillClose_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000A5894 File Offset: 0x000A3A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19348, XrefRangeEnd = 19360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameIntroInfoPannel.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000A58C8 File Offset: 0x000A3AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19360, XrefRangeEnd = 19372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GotoSelectorPannel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameIntroInfoPannel.NativeMethodInfoPtr_GotoSelectorPannel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000A58FC File Offset: 0x000A3AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19372, XrefRangeEnd = 19385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFadeFinish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameIntroInfoPannel.NativeMethodInfoPtr_OnFadeFinish_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000A5930 File Offset: 0x000A3B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19385, XrefRangeEnd = 19395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameIntroInfoPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000A596C File Offset: 0x000A3B6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19396, RefRangeEnd = 19400, XrefRangeStart = 19395, XrefRangeEnd = 19396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicGameIntroInfoPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameIntroInfoPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000A59A8 File Offset: 0x000A3BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__13_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameIntroInfoPannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000A59DC File Offset: 0x000A3BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19400, XrefRangeEnd = 19409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__13_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameIntroInfoPannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000A5A10 File Offset: 0x000A3C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19409, XrefRangeEnd = 19420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnClose_b__15_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameIntroInfoPannel.NativeMethodInfoPtr__OnClose_b__15_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002FD2 File Offset: 0x000011D2
		public MusicGameIntroInfoPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000202 RID: 514 RVA: 0x000A5A44 File Offset: 0x000A3C44
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002FDB File Offset: 0x000011DB
		public unsafe static string EXIT_MUSICGAME_WARNING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MusicGameIntroInfoPannel.NativeFieldInfoPtr_EXIT_MUSICGAME_WARNING, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicGameIntroInfoPannel.NativeFieldInfoPtr_EXIT_MUSICGAME_WARNING, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000204 RID: 516 RVA: 0x000A5A64 File Offset: 0x000A3C64
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002FED File Offset: 0x000011ED
		public unsafe UIButtonSimple startButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_startButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_startButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000A5A94 File Offset: 0x000A3C94
		// (set) Token: 0x06000207 RID: 519 RVA: 0x0000300C File Offset: 0x0000120C
		public unsafe UIButtonSimple endButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_endButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_endButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000208 RID: 520 RVA: 0x000A5AC4 File Offset: 0x000A3CC4
		// (set) Token: 0x06000209 RID: 521 RVA: 0x0000302B File Offset: 0x0000122B
		public unsafe UIButtonSimple customButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_customButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_customButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600020A RID: 522 RVA: 0x000A5AF4 File Offset: 0x000A3CF4
		// (set) Token: 0x0600020B RID: 523 RVA: 0x0000304A File Offset: 0x0000124A
		public unsafe MusicGameMapSelectPannel mapSelectPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_mapSelectPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameMapSelectPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_mapSelectPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000A5B24 File Offset: 0x000A3D24
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00003069 File Offset: 0x00001269
		public unsafe AssetReference MusicGameMenuBGMPackage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_MusicGameMenuBGMPackage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_MusicGameMenuBGMPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600020E RID: 526 RVA: 0x000A5B54 File Offset: 0x000A3D54
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00003088 File Offset: 0x00001288
		public unsafe DialogBoxPannel DialogBoxPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_DialogBoxPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogBoxPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_DialogBoxPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000210 RID: 528 RVA: 0x000A5B84 File Offset: 0x000A3D84
		// (set) Token: 0x06000211 RID: 529 RVA: 0x000030A7 File Offset: 0x000012A7
		public unsafe MusicCustomizerBootstrapPanel m_BootstrapPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_m_BootstrapPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicCustomizerBootstrapPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_m_BootstrapPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000212 RID: 530 RVA: 0x000A5BB4 File Offset: 0x000A3DB4
		// (set) Token: 0x06000213 RID: 531 RVA: 0x000030C6 File Offset: 0x000012C6
		public unsafe LoopedBGMPackage m_LastPlayingBGMPackage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_m_LastPlayingBGMPackage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_m_LastPlayingBGMPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000214 RID: 532 RVA: 0x000A5BE4 File Offset: 0x000A3DE4
		// (set) Token: 0x06000215 RID: 533 RVA: 0x000030E5 File Offset: 0x000012E5
		public unsafe IAssetHandle<LoopedBGMPackage> m_LoadedBGMHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_m_LoadedBGMHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<LoopedBGMPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel.NativeFieldInfoPtr_m_LoadedBGMHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeFieldInfoPtr_EXIT_MUSICGAME_WARNING;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr_startButton;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr_endButton;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_customButton;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeFieldInfoPtr_mapSelectPannel;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeFieldInfoPtr_MusicGameMenuBGMPackage;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeFieldInfoPtr_DialogBoxPannel;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr_m_BootstrapPanel;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeFieldInfoPtr_m_LastPlayingBGMPackage;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadedBGMHandle;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_OnWillClose_Private_Void_CallbackContext_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_GotoSelectorPannel_Private_Void_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_OnFadeFinish_Private_Void_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_0_Private_Void_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_1_Private_Void_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr__OnClose_b__15_0_Private_Void_0;

		// Token: 0x02000482 RID: 1154
		[ObfuscatedName("MusicGame.UI.MusicGameIntroInfoPannel+<OnPanelOpenAsync>d__11")]
		public sealed class _OnPanelOpenAsync_d__11 : ValueType
		{
			// Token: 0x06007CE6 RID: 31974 RVA: 0x0023C100 File Offset: 0x0023A300
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPanelOpenAsync_d__11()
			{
				Il2CppClassPointerStore<MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameIntroInfoPannel>.NativeClassPtr, "<OnPanelOpenAsync>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11>.NativeClassPtr);
				MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11>.NativeClassPtr, "<>1__state");
				MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11>.NativeClassPtr, "<>t__builder");
				MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11>.NativeClassPtr, "<>4__this");
				MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11>.NativeClassPtr, "<>u__1");
				MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11>.NativeClassPtr, "<>u__2");
				MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11>.NativeClassPtr, 100663583);
				MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11>.NativeClassPtr, 100663584);
			}

			// Token: 0x06007CE7 RID: 31975 RVA: 0x0023C1B8 File Offset: 0x0023A3B8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 19284, RefRangeEnd = 19286, XrefRangeStart = 19241, XrefRangeEnd = 19284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007CE8 RID: 31976 RVA: 0x0023C1F0 File Offset: 0x0023A3F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007CE9 RID: 31977 RVA: 0x00043404 File Offset: 0x00041604
			public _OnPanelOpenAsync_d__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06007CEA RID: 31978 RVA: 0x0004340D File Offset: 0x0004160D
			public _OnPanelOpenAsync_d__11() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11>.NativeClassPtr))
			{
			}

			// Token: 0x17002A49 RID: 10825
			// (get) Token: 0x06007CEB RID: 31979 RVA: 0x0023C238 File Offset: 0x0023A438
			// (set) Token: 0x06007CEC RID: 31980 RVA: 0x0004341F File Offset: 0x0004161F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002A4A RID: 10826
			// (get) Token: 0x06007CED RID: 31981 RVA: 0x0023C260 File Offset: 0x0023A460
			// (set) Token: 0x06007CEE RID: 31982 RVA: 0x0004343A File Offset: 0x0004163A
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002A4B RID: 10827
			// (get) Token: 0x06007CEF RID: 31983 RVA: 0x0023C290 File Offset: 0x0023A490
			// (set) Token: 0x06007CF0 RID: 31984 RVA: 0x00043468 File Offset: 0x00041668
			public unsafe MusicGameIntroInfoPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameIntroInfoPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A4C RID: 10828
			// (get) Token: 0x06007CF1 RID: 31985 RVA: 0x0023C2C0 File Offset: 0x0023A4C0
			// (set) Token: 0x06007CF2 RID: 31986 RVA: 0x00043487 File Offset: 0x00041687
			public UniTask<IAssetHandle<LoopedBGMPackage>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeFieldInfoPtr___u__1);
					return new UniTask<IAssetHandle<LoopedBGMPackage>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<LoopedBGMPackage>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<LoopedBGMPackage>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002A4D RID: 10829
			// (get) Token: 0x06007CF3 RID: 31987 RVA: 0x0023C2F0 File Offset: 0x0023A4F0
			// (set) Token: 0x06007CF4 RID: 31988 RVA: 0x000434B5 File Offset: 0x000416B5
			public UniTask.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeFieldInfoPtr___u__2);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameIntroInfoPannel._OnPanelOpenAsync_d__11.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005232 RID: 21042
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005233 RID: 21043
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005234 RID: 21044
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005235 RID: 21045
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005236 RID: 21046
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04005237 RID: 21047
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005238 RID: 21048
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
