using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace MusicGame.UI
{
	// Token: 0x02000024 RID: 36
	public class MusicResultPannel : UISubPanel<MusicSelectorPannel>
	{
		// Token: 0x06000359 RID: 857 RVA: 0x000A9850 File Offset: 0x000A7A50
		// Note: this type is marked as 'beforefieldinit'.
		static MusicResultPannel()
		{
			Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "MusicResultPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr);
			MusicResultPannel.NativeFieldInfoPtr_DIGIT_TYPE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "DIGIT_TYPE_SPEED");
			MusicResultPannel.NativeFieldInfoPtr_ZERO_STRING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "ZERO_STRING");
			MusicResultPannel.NativeFieldInfoPtr_musicNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "musicNameText");
			MusicResultPannel.NativeFieldInfoPtr_musicLevelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "musicLevelText");
			MusicResultPannel.NativeFieldInfoPtr_scoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "scoreText");
			MusicResultPannel.NativeFieldInfoPtr_perfectText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "perfectText");
			MusicResultPannel.NativeFieldInfoPtr_goodText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "goodText");
			MusicResultPannel.NativeFieldInfoPtr_badText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "badText");
			MusicResultPannel.NativeFieldInfoPtr_keyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "keyMode");
			MusicResultPannel.NativeFieldInfoPtr_characterImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "characterImage");
			MusicResultPannel.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "confirmButton");
			MusicResultPannel.NativeFieldInfoPtr_restartButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "restartButton");
			MusicResultPannel.NativeFieldInfoPtr_newHighScoreEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "newHighScoreEffect");
			MusicResultPannel.NativeFieldInfoPtr_skipIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "skipIndicator");
			MusicResultPannel.NativeFieldInfoPtr_CDComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "CDComponent");
			MusicResultPannel.NativeFieldInfoPtr_rankVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "rankVisual");
			MusicResultPannel.NativeFieldInfoPtr_rankDialogText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "rankDialogText");
			MusicResultPannel.NativeFieldInfoPtr_ranks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "ranks");
			MusicResultPannel.NativeFieldInfoPtr_m_AnimatedPortrayalCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "m_AnimatedPortrayalCoroutine");
			MusicResultPannel.NativeFieldInfoPtr__OpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "<OpenContext>k__BackingField");
			MusicResultPannel.NativeFieldInfoPtr__GetScoreLevelCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "<GetScoreLevelCallback>k__BackingField");
			MusicResultPannel.NativeFieldInfoPtr__CloseMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "<CloseMode>k__BackingField");
			MusicResultPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, 100663794);
			MusicResultPannel.NativeMethodInfoPtr_get_OpenContext_Private_get_Nullable_1_MusicFinalScoreOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, 100663795);
			MusicResultPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_MusicFinalScoreOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, 100663796);
			MusicResultPannel.NativeMethodInfoPtr_get_GetScoreLevelCallback_Private_get_Func_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, 100663797);
			MusicResultPannel.NativeMethodInfoPtr_set_GetScoreLevelCallback_Public_set_Void_Func_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, 100663798);
			MusicResultPannel.NativeMethodInfoPtr_get_CloseMode_Public_get_PannelCloseMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, 100663799);
			MusicResultPannel.NativeMethodInfoPtr_set_CloseMode_Public_set_Void_PannelCloseMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, 100663800);
			MusicResultPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, 100663801);
			MusicResultPannel.NativeMethodInfoPtr_TypeCoroutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, 100663802);
			MusicResultPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, 100663803);
			MusicResultPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, 100663804);
			MusicResultPannel.NativeMethodInfoPtr_Restart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, 100663805);
			MusicResultPannel.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, 100663806);
			MusicResultPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, 100663807);
			MusicResultPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, 100663808);
			MusicResultPannel.NativeMethodInfoPtr__OnClose_b__38_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, 100663809);
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600035A RID: 858 RVA: 0x000A9B78 File Offset: 0x000A7D78
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicResultPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600035B RID: 859 RVA: 0x000A9BC0 File Offset: 0x000A7DC0
		// (set) Token: 0x0600035C RID: 860 RVA: 0x000A9BF8 File Offset: 0x000A7DF8
		public unsafe Nullable<MusicResultPannel.MusicFinalScoreOpenContext> OpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.NativeMethodInfoPtr_get_OpenContext_Private_get_Nullable_1_MusicFinalScoreOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<MusicResultPannel.MusicFinalScoreOpenContext>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21943, XrefRangeEnd = 21944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_MusicFinalScoreOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600035D RID: 861 RVA: 0x000A9C40 File Offset: 0x000A7E40
		// (set) Token: 0x0600035E RID: 862 RVA: 0x000A9C80 File Offset: 0x000A7E80
		public unsafe Func<int, int> GetScoreLevelCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.NativeMethodInfoPtr_get_GetScoreLevelCallback_Private_get_Func_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21944, XrefRangeEnd = 21945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.NativeMethodInfoPtr_set_GetScoreLevelCallback_Public_set_Void_Func_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600035F RID: 863 RVA: 0x000A9CC4 File Offset: 0x000A7EC4
		// (set) Token: 0x06000360 RID: 864 RVA: 0x000A9D00 File Offset: 0x000A7F00
		public unsafe MusicSelectorPannel.PannelCloseMode CloseMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.NativeMethodInfoPtr_get_CloseMode_Public_get_PannelCloseMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.NativeMethodInfoPtr_set_CloseMode_Public_set_Void_PannelCloseMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000A9D40 File Offset: 0x000A7F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21945, XrefRangeEnd = 22015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicResultPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000A9D7C File Offset: 0x000A7F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22015, XrefRangeEnd = 22020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TypeCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.NativeMethodInfoPtr_TypeCoroutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000A9DBC File Offset: 0x000A7FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22020, XrefRangeEnd = 22024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicResultPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000A9DF8 File Offset: 0x000A7FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22024, XrefRangeEnd = 22039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicResultPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000A9E34 File Offset: 0x000A8034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22039, XrefRangeEnd = 22051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Restart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.NativeMethodInfoPtr_Restart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000A9E68 File Offset: 0x000A8068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22051, XrefRangeEnd = 22063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000A9E9C File Offset: 0x000A809C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22063, XrefRangeEnd = 22082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicResultPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000A9ED8 File Offset: 0x000A80D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22082, XrefRangeEnd = 22085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicResultPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x000A9F14 File Offset: 0x000A8114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22085, XrefRangeEnd = 22093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnClose_b__38_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.NativeMethodInfoPtr__OnClose_b__38_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00003D60 File Offset: 0x00001F60
		public MusicResultPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600036B RID: 875 RVA: 0x000A9F48 File Offset: 0x000A8148
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00003D69 File Offset: 0x00001F69
		public unsafe static float DIGIT_TYPE_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MusicResultPannel.NativeFieldInfoPtr_DIGIT_TYPE_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicResultPannel.NativeFieldInfoPtr_DIGIT_TYPE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600036D RID: 877 RVA: 0x000A9F64 File Offset: 0x000A8164
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00003D77 File Offset: 0x00001F77
		public unsafe static string ZERO_STRING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MusicResultPannel.NativeFieldInfoPtr_ZERO_STRING, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicResultPannel.NativeFieldInfoPtr_ZERO_STRING, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600036F RID: 879 RVA: 0x000A9F84 File Offset: 0x000A8184
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00003D89 File Offset: 0x00001F89
		public unsafe TextMeshProUGUI musicNameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_musicNameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_musicNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000371 RID: 881 RVA: 0x000A9FB4 File Offset: 0x000A81B4
		// (set) Token: 0x06000372 RID: 882 RVA: 0x00003DA8 File Offset: 0x00001FA8
		public unsafe TextMeshProUGUI musicLevelText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_musicLevelText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_musicLevelText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000373 RID: 883 RVA: 0x000A9FE4 File Offset: 0x000A81E4
		// (set) Token: 0x06000374 RID: 884 RVA: 0x00003DC7 File Offset: 0x00001FC7
		public unsafe TextMeshProUGUI scoreText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_scoreText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_scoreText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000375 RID: 885 RVA: 0x000AA014 File Offset: 0x000A8214
		// (set) Token: 0x06000376 RID: 886 RVA: 0x00003DE6 File Offset: 0x00001FE6
		public unsafe TextMeshProUGUI perfectText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_perfectText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_perfectText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000377 RID: 887 RVA: 0x000AA044 File Offset: 0x000A8244
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00003E05 File Offset: 0x00002005
		public unsafe TextMeshProUGUI goodText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_goodText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_goodText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000379 RID: 889 RVA: 0x000AA074 File Offset: 0x000A8274
		// (set) Token: 0x0600037A RID: 890 RVA: 0x00003E24 File Offset: 0x00002024
		public unsafe TextMeshProUGUI badText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_badText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_badText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600037B RID: 891 RVA: 0x000AA0A4 File Offset: 0x000A82A4
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00003E43 File Offset: 0x00002043
		public unsafe TextMeshProUGUI keyMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_keyMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_keyMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600037D RID: 893 RVA: 0x000AA0D4 File Offset: 0x000A82D4
		// (set) Token: 0x0600037E RID: 894 RVA: 0x00003E62 File Offset: 0x00002062
		public unsafe Image characterImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_characterImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_characterImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600037F RID: 895 RVA: 0x000AA104 File Offset: 0x000A8304
		// (set) Token: 0x06000380 RID: 896 RVA: 0x00003E81 File Offset: 0x00002081
		public unsafe UIButtonSimple confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000381 RID: 897 RVA: 0x000AA134 File Offset: 0x000A8334
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00003EA0 File Offset: 0x000020A0
		public unsafe UIButtonSimple restartButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_restartButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_restartButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000383 RID: 899 RVA: 0x000AA164 File Offset: 0x000A8364
		// (set) Token: 0x06000384 RID: 900 RVA: 0x00003EBF File Offset: 0x000020BF
		public unsafe GameObject newHighScoreEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_newHighScoreEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_newHighScoreEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000385 RID: 901 RVA: 0x000AA194 File Offset: 0x000A8394
		// (set) Token: 0x06000386 RID: 902 RVA: 0x00003EDE File Offset: 0x000020DE
		public unsafe GameObject skipIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_skipIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_skipIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000387 RID: 903 RVA: 0x000AA1C4 File Offset: 0x000A83C4
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00003EFD File Offset: 0x000020FD
		public unsafe UIElementCluster CDComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_CDComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_CDComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000389 RID: 905 RVA: 0x000AA1F4 File Offset: 0x000A83F4
		// (set) Token: 0x0600038A RID: 906 RVA: 0x00003F1C File Offset: 0x0000211C
		public unsafe Image rankVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_rankVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_rankVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600038B RID: 907 RVA: 0x000AA224 File Offset: 0x000A8424
		// (set) Token: 0x0600038C RID: 908 RVA: 0x00003F3B File Offset: 0x0000213B
		public unsafe TMP_Text rankDialogText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_rankDialogText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_rankDialogText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600038D RID: 909 RVA: 0x000AA254 File Offset: 0x000A8454
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00003F5A File Offset: 0x0000215A
		public unsafe Il2CppReferenceArray<SerializableKeyValuePair<string, Sprite>> ranks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_ranks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SerializableKeyValuePair<string, Sprite>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_ranks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600038F RID: 911 RVA: 0x000AA284 File Offset: 0x000A8484
		// (set) Token: 0x06000390 RID: 912 RVA: 0x00003F79 File Offset: 0x00002179
		public unsafe Coroutine m_AnimatedPortrayalCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_m_AnimatedPortrayalCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr_m_AnimatedPortrayalCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000391 RID: 913 RVA: 0x000AA2B4 File Offset: 0x000A84B4
		// (set) Token: 0x06000392 RID: 914 RVA: 0x00003F98 File Offset: 0x00002198
		public Nullable<MusicResultPannel.MusicFinalScoreOpenContext> _OpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr__OpenContext_k__BackingField);
				return new Nullable<MusicResultPannel.MusicFinalScoreOpenContext>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<MusicResultPannel.MusicFinalScoreOpenContext>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr__OpenContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<MusicResultPannel.MusicFinalScoreOpenContext>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000393 RID: 915 RVA: 0x000AA2E4 File Offset: 0x000A84E4
		// (set) Token: 0x06000394 RID: 916 RVA: 0x00003FC6 File Offset: 0x000021C6
		public unsafe Func<int, int> _GetScoreLevelCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr__GetScoreLevelCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr__GetScoreLevelCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000395 RID: 917 RVA: 0x000AA314 File Offset: 0x000A8514
		// (set) Token: 0x06000396 RID: 918 RVA: 0x00003FE5 File Offset: 0x000021E5
		public unsafe MusicSelectorPannel.PannelCloseMode _CloseMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr__CloseMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.NativeFieldInfoPtr__CloseMode_k__BackingField)) = value;
			}
		}

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeFieldInfoPtr_DIGIT_TYPE_SPEED;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeFieldInfoPtr_ZERO_STRING;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeFieldInfoPtr_musicNameText;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeFieldInfoPtr_musicLevelText;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr_scoreText;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeFieldInfoPtr_perfectText;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeFieldInfoPtr_goodText;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeFieldInfoPtr_badText;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeFieldInfoPtr_keyMode;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeFieldInfoPtr_characterImage;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeFieldInfoPtr_restartButton;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeFieldInfoPtr_newHighScoreEffect;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeFieldInfoPtr_skipIndicator;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeFieldInfoPtr_CDComponent;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeFieldInfoPtr_rankVisual;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeFieldInfoPtr_rankDialogText;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeFieldInfoPtr_ranks;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimatedPortrayalCoroutine;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeFieldInfoPtr__OpenContext_k__BackingField;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeFieldInfoPtr__GetScoreLevelCallback_k__BackingField;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeFieldInfoPtr__CloseMode_k__BackingField;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Private_get_Nullable_1_MusicFinalScoreOpenContext_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_MusicFinalScoreOpenContext_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_get_GetScoreLevelCallback_Private_get_Func_2_Int32_Int32_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_set_GetScoreLevelCallback_Public_set_Void_Func_2_Int32_Int32_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseMode_Public_get_PannelCloseMode_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseMode_Public_set_Void_PannelCloseMode_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_TypeCoroutine_Private_IEnumerator_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_Restart_Private_Void_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr__OnClose_b__38_0_Private_Void_0;

		// Token: 0x02000499 RID: 1177
		public sealed class MusicFinalScoreOpenContext : ValueType
		{
			// Token: 0x06007E0B RID: 32267 RVA: 0x0023F820 File Offset: 0x0023DA20
			// Note: this type is marked as 'beforefieldinit'.
			static MusicFinalScoreOpenContext()
			{
				Il2CppClassPointerStore<MusicResultPannel.MusicFinalScoreOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "MusicFinalScoreOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicResultPannel.MusicFinalScoreOpenContext>.NativeClassPtr);
				MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_MusicLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel.MusicFinalScoreOpenContext>.NativeClassPtr, "MusicLabel");
				MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_IsEasyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel.MusicFinalScoreOpenContext>.NativeClassPtr, "IsEasyMode");
				MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel.MusicFinalScoreOpenContext>.NativeClassPtr, "Score");
				MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_LastHighScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel.MusicFinalScoreOpenContext>.NativeClassPtr, "LastHighScore");
				MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_Perfect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel.MusicFinalScoreOpenContext>.NativeClassPtr, "Perfect");
				MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_Good = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel.MusicFinalScoreOpenContext>.NativeClassPtr, "Good");
				MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_Bad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel.MusicFinalScoreOpenContext>.NativeClassPtr, "Bad");
				MusicResultPannel.MusicFinalScoreOpenContext.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel.MusicFinalScoreOpenContext>.NativeClassPtr, 100663810);
			}

			// Token: 0x06007E0C RID: 32268 RVA: 0x0023F8EC File Offset: 0x0023DAEC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21853, RefRangeEnd = 21854, XrefRangeStart = 21852, XrefRangeEnd = 21853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MusicFinalScoreOpenContext(string musicLabel, bool isEasyMode, int score, int lastHighScore, int perfect, int good, int bad) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicResultPannel.MusicFinalScoreOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(musicLabel);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEasyMode;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastHighScore;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref perfect;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref good;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bad;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.MusicFinalScoreOpenContext.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E0D RID: 32269 RVA: 0x00043D2F File Offset: 0x00041F2F
			public MusicFinalScoreOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06007E0E RID: 32270 RVA: 0x00043D38 File Offset: 0x00041F38
			public MusicFinalScoreOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicResultPannel.MusicFinalScoreOpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x17002A96 RID: 10902
			// (get) Token: 0x06007E0F RID: 32271 RVA: 0x0023F990 File Offset: 0x0023DB90
			// (set) Token: 0x06007E10 RID: 32272 RVA: 0x00043D4A File Offset: 0x00041F4A
			public unsafe string MusicLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_MusicLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_MusicLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002A97 RID: 10903
			// (get) Token: 0x06007E11 RID: 32273 RVA: 0x0023F9B8 File Offset: 0x0023DBB8
			// (set) Token: 0x06007E12 RID: 32274 RVA: 0x00043D69 File Offset: 0x00041F69
			public unsafe bool IsEasyMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_IsEasyMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_IsEasyMode)) = value;
				}
			}

			// Token: 0x17002A98 RID: 10904
			// (get) Token: 0x06007E13 RID: 32275 RVA: 0x0023F9E0 File Offset: 0x0023DBE0
			// (set) Token: 0x06007E14 RID: 32276 RVA: 0x00043D84 File Offset: 0x00041F84
			public unsafe int Score
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_Score);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_Score)) = value;
				}
			}

			// Token: 0x17002A99 RID: 10905
			// (get) Token: 0x06007E15 RID: 32277 RVA: 0x0023FA08 File Offset: 0x0023DC08
			// (set) Token: 0x06007E16 RID: 32278 RVA: 0x00043D9F File Offset: 0x00041F9F
			public unsafe int LastHighScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_LastHighScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_LastHighScore)) = value;
				}
			}

			// Token: 0x17002A9A RID: 10906
			// (get) Token: 0x06007E17 RID: 32279 RVA: 0x0023FA30 File Offset: 0x0023DC30
			// (set) Token: 0x06007E18 RID: 32280 RVA: 0x00043DBA File Offset: 0x00041FBA
			public unsafe int Perfect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_Perfect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_Perfect)) = value;
				}
			}

			// Token: 0x17002A9B RID: 10907
			// (get) Token: 0x06007E19 RID: 32281 RVA: 0x0023FA58 File Offset: 0x0023DC58
			// (set) Token: 0x06007E1A RID: 32282 RVA: 0x00043DD5 File Offset: 0x00041FD5
			public unsafe int Good
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_Good);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_Good)) = value;
				}
			}

			// Token: 0x17002A9C RID: 10908
			// (get) Token: 0x06007E1B RID: 32283 RVA: 0x0023FA80 File Offset: 0x0023DC80
			// (set) Token: 0x06007E1C RID: 32284 RVA: 0x00043DF0 File Offset: 0x00041FF0
			public unsafe int Bad
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_Bad);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.MusicFinalScoreOpenContext.NativeFieldInfoPtr_Bad)) = value;
				}
			}

			// Token: 0x040052E8 RID: 21224
			private static readonly IntPtr NativeFieldInfoPtr_MusicLabel;

			// Token: 0x040052E9 RID: 21225
			private static readonly IntPtr NativeFieldInfoPtr_IsEasyMode;

			// Token: 0x040052EA RID: 21226
			private static readonly IntPtr NativeFieldInfoPtr_Score;

			// Token: 0x040052EB RID: 21227
			private static readonly IntPtr NativeFieldInfoPtr_LastHighScore;

			// Token: 0x040052EC RID: 21228
			private static readonly IntPtr NativeFieldInfoPtr_Perfect;

			// Token: 0x040052ED RID: 21229
			private static readonly IntPtr NativeFieldInfoPtr_Good;

			// Token: 0x040052EE RID: 21230
			private static readonly IntPtr NativeFieldInfoPtr_Bad;

			// Token: 0x040052EF RID: 21231
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_Int32_Int32_Int32_Int32_0;
		}

		// Token: 0x0200049A RID: 1178
		[ObfuscatedName("MusicGame.UI.MusicResultPannel+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
		{
			// Token: 0x06007E1D RID: 32285 RVA: 0x0023FAA8 File Offset: 0x0023DCA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0>.NativeClassPtr);
				MusicResultPannel.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0>.NativeClassPtr, "<>4__this");
				MusicResultPannel.__c__DisplayClass34_0.NativeFieldInfoPtr_shouldSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0>.NativeClassPtr, "shouldSkip");
				MusicResultPannel.__c__DisplayClass34_0.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0>.NativeClassPtr, "active");
				MusicResultPannel.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0>.NativeClassPtr, 100663811);
				MusicResultPannel.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0>.NativeClassPtr, 100663812);
				MusicResultPannel.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0>.NativeClassPtr, 100663813);
				MusicResultPannel.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_TextMeshProUGUI_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0>.NativeClassPtr, 100663814);
				MusicResultPannel.__c__DisplayClass34_0.NativeMethodInfoPtr__TypeCoroutine_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0>.NativeClassPtr, 100663815);
			}

			// Token: 0x06007E1E RID: 32286 RVA: 0x0023FB74 File Offset: 0x0023DD74
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E1F RID: 32287 RVA: 0x0023FBB0 File Offset: 0x0023DDB0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21914, RefRangeEnd = 21915, XrefRangeStart = 21876, XrefRangeEnd = 21914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Boolean_0(bool doReg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref doReg;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E20 RID: 32288 RVA: 0x0023FBF0 File Offset: 0x0023DDF0
			[CallerCount(0)]
			public unsafe void Method_Internal_Void_CallbackContext_0(InputAction.CallbackContext _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E21 RID: 32289 RVA: 0x0023FC38 File Offset: 0x0023DE38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21915, XrefRangeEnd = 21921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_TextMeshProUGUI_Int32_PDM_0(TextMeshProUGUI component, int value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_TextMeshProUGUI_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007E22 RID: 32290 RVA: 0x0023FC98 File Offset: 0x0023DE98
			[CallerCount(0)]
			public unsafe bool _TypeCoroutine_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.__c__DisplayClass34_0.NativeMethodInfoPtr__TypeCoroutine_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007E23 RID: 32291 RVA: 0x00043E0B File Offset: 0x0004200B
			public __c__DisplayClass34_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A9D RID: 10909
			// (get) Token: 0x06007E24 RID: 32292 RVA: 0x0023FCD4 File Offset: 0x0023DED4
			// (set) Token: 0x06007E25 RID: 32293 RVA: 0x00043E14 File Offset: 0x00042014
			public unsafe MusicResultPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicResultPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A9E RID: 10910
			// (get) Token: 0x06007E26 RID: 32294 RVA: 0x0023FD04 File Offset: 0x0023DF04
			// (set) Token: 0x06007E27 RID: 32295 RVA: 0x00043E33 File Offset: 0x00042033
			public unsafe bool shouldSkip
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.NativeFieldInfoPtr_shouldSkip);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.NativeFieldInfoPtr_shouldSkip)) = value;
				}
			}

			// Token: 0x17002A9F RID: 10911
			// (get) Token: 0x06007E28 RID: 32296 RVA: 0x0023FD2C File Offset: 0x0023DF2C
			// (set) Token: 0x06007E29 RID: 32297 RVA: 0x00043E4E File Offset: 0x0004204E
			public unsafe int active
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.NativeFieldInfoPtr_active);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.NativeFieldInfoPtr_active)) = value;
				}
			}

			// Token: 0x040052F0 RID: 21232
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040052F1 RID: 21233
			private static readonly IntPtr NativeFieldInfoPtr_shouldSkip;

			// Token: 0x040052F2 RID: 21234
			private static readonly IntPtr NativeFieldInfoPtr_active;

			// Token: 0x040052F3 RID: 21235
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040052F4 RID: 21236
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_0;

			// Token: 0x040052F5 RID: 21237
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_CallbackContext_0;

			// Token: 0x040052F6 RID: 21238
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_TextMeshProUGUI_Int32_PDM_0;

			// Token: 0x040052F7 RID: 21239
			private static readonly IntPtr NativeMethodInfoPtr__TypeCoroutine_b__3_Internal_Boolean_0;

			// Token: 0x02000FA7 RID: 4007
			[ObfuscatedName("MusicGame.UI.MusicResultPannel+<>c__DisplayClass34_0+<<TypeCoroutine>g__DoType|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011493 RID: 70803 RVA: 0x003FA7C4 File Offset: 0x003F89C4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique()
				{
					Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0>.NativeClassPtr, "<<TypeCoroutine>g__DoType|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique>.NativeClassPtr);
					MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique>.NativeClassPtr, "<>1__state");
					MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique>.NativeClassPtr, "<>2__current");
					MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique>.NativeClassPtr, "<>4__this");
					MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique>.NativeClassPtr, "value");
					MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr_component = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique>.NativeClassPtr, "component");
					MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr__progress_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique>.NativeClassPtr, "<progress>5__2");
					MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr__duration_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique>.NativeClassPtr, "<duration>5__3");
					MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique>.NativeClassPtr, 100663816);
					MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique>.NativeClassPtr, 100663817);
					MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique>.NativeClassPtr, 100663818);
					MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique>.NativeClassPtr, 100663819);
					MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique>.NativeClassPtr, 100663820);
					MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique>.NativeClassPtr, 100663821);
				}

				// Token: 0x06011494 RID: 70804 RVA: 0x003FA8F4 File Offset: 0x003F8AF4
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011495 RID: 70805 RVA: 0x003FA93C File Offset: 0x003F8B3C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011496 RID: 70806 RVA: 0x003FA970 File Offset: 0x003F8B70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21854, XrefRangeEnd = 21870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170059DF RID: 23007
				// (get) Token: 0x06011497 RID: 70807 RVA: 0x003FA9AC File Offset: 0x003F8BAC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011498 RID: 70808 RVA: 0x003FA9EC File Offset: 0x003F8BEC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21870, XrefRangeEnd = 21876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170059E0 RID: 23008
				// (get) Token: 0x06011499 RID: 70809 RVA: 0x003FAA20 File Offset: 0x003F8C20
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601149A RID: 70810 RVA: 0x00096630 File Offset: 0x00094830
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170059D8 RID: 23000
				// (get) Token: 0x0601149B RID: 70811 RVA: 0x003FAA60 File Offset: 0x003F8C60
				// (set) Token: 0x0601149C RID: 70812 RVA: 0x00096639 File Offset: 0x00094839
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170059D9 RID: 23001
				// (get) Token: 0x0601149D RID: 70813 RVA: 0x003FAA88 File Offset: 0x003F8C88
				// (set) Token: 0x0601149E RID: 70814 RVA: 0x00096654 File Offset: 0x00094854
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059DA RID: 23002
				// (get) Token: 0x0601149F RID: 70815 RVA: 0x003FAAB8 File Offset: 0x003F8CB8
				// (set) Token: 0x060114A0 RID: 70816 RVA: 0x00096673 File Offset: 0x00094873
				public unsafe MusicResultPannel.__c__DisplayClass34_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicResultPannel.__c__DisplayClass34_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059DB RID: 23003
				// (get) Token: 0x060114A1 RID: 70817 RVA: 0x003FAAE8 File Offset: 0x003F8CE8
				// (set) Token: 0x060114A2 RID: 70818 RVA: 0x00096692 File Offset: 0x00094892
				public unsafe int value
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr_value);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr_value)) = value;
					}
				}

				// Token: 0x170059DC RID: 23004
				// (get) Token: 0x060114A3 RID: 70819 RVA: 0x003FAB10 File Offset: 0x003F8D10
				// (set) Token: 0x060114A4 RID: 70820 RVA: 0x000966AD File Offset: 0x000948AD
				public unsafe TextMeshProUGUI component
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr_component);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr_component), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059DD RID: 23005
				// (get) Token: 0x060114A5 RID: 70821 RVA: 0x003FAB40 File Offset: 0x003F8D40
				// (set) Token: 0x060114A6 RID: 70822 RVA: 0x000966CC File Offset: 0x000948CC
				public unsafe float _progress_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr__progress_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr__progress_5__2)) = value;
					}
				}

				// Token: 0x170059DE RID: 23006
				// (get) Token: 0x060114A7 RID: 70823 RVA: 0x003FAB68 File Offset: 0x003F8D68
				// (set) Token: 0x060114A8 RID: 70824 RVA: 0x000966E7 File Offset: 0x000948E7
				public unsafe float _duration_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr__duration_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObvaInTecoSiSiObObUnique.NativeFieldInfoPtr__duration_5__3)) = value;
					}
				}

				// Token: 0x0400AEBB RID: 44731
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AEBC RID: 44732
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AEBD RID: 44733
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AEBE RID: 44734
				private static readonly IntPtr NativeFieldInfoPtr_value;

				// Token: 0x0400AEBF RID: 44735
				private static readonly IntPtr NativeFieldInfoPtr_component;

				// Token: 0x0400AEC0 RID: 44736
				private static readonly IntPtr NativeFieldInfoPtr__progress_5__2;

				// Token: 0x0400AEC1 RID: 44737
				private static readonly IntPtr NativeFieldInfoPtr__duration_5__3;

				// Token: 0x0400AEC2 RID: 44738
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AEC3 RID: 44739
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEC4 RID: 44740
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AEC5 RID: 44741
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AEC6 RID: 44742
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEC7 RID: 44743
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x0200049B RID: 1179
		[ObfuscatedName("MusicGame.UI.MusicResultPannel+<TypeCoroutine>d__34")]
		public sealed class _TypeCoroutine_d__34 : Il2CppSystem.Object
		{
			// Token: 0x06007E2A RID: 32298 RVA: 0x0023FD54 File Offset: 0x0023DF54
			// Note: this type is marked as 'beforefieldinit'.
			static _TypeCoroutine_d__34()
			{
				Il2CppClassPointerStore<MusicResultPannel._TypeCoroutine_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicResultPannel>.NativeClassPtr, "<TypeCoroutine>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicResultPannel._TypeCoroutine_d__34>.NativeClassPtr);
				MusicResultPannel._TypeCoroutine_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel._TypeCoroutine_d__34>.NativeClassPtr, "<>1__state");
				MusicResultPannel._TypeCoroutine_d__34.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel._TypeCoroutine_d__34>.NativeClassPtr, "<>2__current");
				MusicResultPannel._TypeCoroutine_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel._TypeCoroutine_d__34>.NativeClassPtr, "<>4__this");
				MusicResultPannel._TypeCoroutine_d__34.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicResultPannel._TypeCoroutine_d__34>.NativeClassPtr, "<>8__1");
				MusicResultPannel._TypeCoroutine_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel._TypeCoroutine_d__34>.NativeClassPtr, 100663822);
				MusicResultPannel._TypeCoroutine_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel._TypeCoroutine_d__34>.NativeClassPtr, 100663823);
				MusicResultPannel._TypeCoroutine_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel._TypeCoroutine_d__34>.NativeClassPtr, 100663824);
				MusicResultPannel._TypeCoroutine_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel._TypeCoroutine_d__34>.NativeClassPtr, 100663825);
				MusicResultPannel._TypeCoroutine_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel._TypeCoroutine_d__34>.NativeClassPtr, 100663826);
				MusicResultPannel._TypeCoroutine_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicResultPannel._TypeCoroutine_d__34>.NativeClassPtr, 100663827);
			}

			// Token: 0x06007E2B RID: 32299 RVA: 0x0023FE48 File Offset: 0x0023E048
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TypeCoroutine_d__34(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicResultPannel._TypeCoroutine_d__34>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel._TypeCoroutine_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E2C RID: 32300 RVA: 0x0023FE90 File Offset: 0x0023E090
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel._TypeCoroutine_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E2D RID: 32301 RVA: 0x0023FEC4 File Offset: 0x0023E0C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21921, XrefRangeEnd = 21937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel._TypeCoroutine_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002AA4 RID: 10916
			// (get) Token: 0x06007E2E RID: 32302 RVA: 0x0023FF00 File Offset: 0x0023E100
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel._TypeCoroutine_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007E2F RID: 32303 RVA: 0x0023FF40 File Offset: 0x0023E140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21937, XrefRangeEnd = 21943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel._TypeCoroutine_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002AA5 RID: 10917
			// (get) Token: 0x06007E30 RID: 32304 RVA: 0x0023FF74 File Offset: 0x0023E174
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicResultPannel._TypeCoroutine_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007E31 RID: 32305 RVA: 0x00043E69 File Offset: 0x00042069
			public _TypeCoroutine_d__34(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002AA0 RID: 10912
			// (get) Token: 0x06007E32 RID: 32306 RVA: 0x0023FFB4 File Offset: 0x0023E1B4
			// (set) Token: 0x06007E33 RID: 32307 RVA: 0x00043E72 File Offset: 0x00042072
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel._TypeCoroutine_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel._TypeCoroutine_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002AA1 RID: 10913
			// (get) Token: 0x06007E34 RID: 32308 RVA: 0x0023FFDC File Offset: 0x0023E1DC
			// (set) Token: 0x06007E35 RID: 32309 RVA: 0x00043E8D File Offset: 0x0004208D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel._TypeCoroutine_d__34.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel._TypeCoroutine_d__34.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AA2 RID: 10914
			// (get) Token: 0x06007E36 RID: 32310 RVA: 0x0024000C File Offset: 0x0023E20C
			// (set) Token: 0x06007E37 RID: 32311 RVA: 0x00043EAC File Offset: 0x000420AC
			public unsafe MusicResultPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel._TypeCoroutine_d__34.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicResultPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel._TypeCoroutine_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AA3 RID: 10915
			// (get) Token: 0x06007E38 RID: 32312 RVA: 0x0024003C File Offset: 0x0023E23C
			// (set) Token: 0x06007E39 RID: 32313 RVA: 0x00043ECB File Offset: 0x000420CB
			public unsafe MusicResultPannel.__c__DisplayClass34_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel._TypeCoroutine_d__34.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicResultPannel.__c__DisplayClass34_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicResultPannel._TypeCoroutine_d__34.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040052F8 RID: 21240
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040052F9 RID: 21241
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040052FA RID: 21242
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040052FB RID: 21243
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040052FC RID: 21244
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040052FD RID: 21245
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040052FE RID: 21246
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040052FF RID: 21247
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005300 RID: 21248
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005301 RID: 21249
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
