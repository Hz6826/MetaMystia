using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.ShapedLayoutGroup;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MusicGame.UI
{
	// Token: 0x02000023 RID: 35
	public class MusicRankPannel : UISubPanel<MusicSelectorPannel>
	{
		// Token: 0x06000323 RID: 803 RVA: 0x000A8D18 File Offset: 0x000A6F18
		// Note: this type is marked as 'beforefieldinit'.
		static MusicRankPannel()
		{
			Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "MusicRankPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr);
			MusicRankPannel.NativeFieldInfoPtr_SELF_TOP_INDICATOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "SELF_TOP_INDICATOR");
			MusicRankPannel.NativeFieldInfoPtr_SELF_INDICATOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "SELF_INDICATOR");
			MusicRankPannel.NativeFieldInfoPtr_INPUTHELPER_CONTINUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "INPUTHELPER_CONTINUE");
			MusicRankPannel.NativeFieldInfoPtr_INPUTHELPER_BACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "INPUTHELPER_BACK");
			MusicRankPannel.NativeFieldInfoPtr_AIORankElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "AIORankElement");
			MusicRankPannel.NativeFieldInfoPtr_RankTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "RankTransform");
			MusicRankPannel.NativeFieldInfoPtr_Btn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "Btn");
			MusicRankPannel.NativeFieldInfoPtr_BtnText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "BtnText");
			MusicRankPannel.NativeFieldInfoPtr_CDComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "CDComponent");
			MusicRankPannel.NativeFieldInfoPtr_Top1RankSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "Top1RankSprite");
			MusicRankPannel.NativeFieldInfoPtr_Top2RankSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "Top2RankSprite");
			MusicRankPannel.NativeFieldInfoPtr_Top3RankSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "Top3RankSprite");
			MusicRankPannel.NativeFieldInfoPtr_m_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "m_List");
			MusicRankPannel.NativeFieldInfoPtr_m_TopRankSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "m_TopRankSprites");
			MusicRankPannel.NativeFieldInfoPtr__OpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "<OpenContext>k__BackingField");
			MusicRankPannel.NativeFieldInfoPtr__HasContinueButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "<HasContinueButton>k__BackingField");
			MusicRankPannel.NativeMethodInfoPtr_get_OpenContext_Private_get_MusicFinalScoreOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663764);
			MusicRankPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_MusicFinalScoreOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663765);
			MusicRankPannel.NativeMethodInfoPtr_get_HasContinueButton_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663766);
			MusicRankPannel.NativeMethodInfoPtr_set_HasContinueButton_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663767);
			MusicRankPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663768);
			MusicRankPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663769);
			MusicRankPannel.NativeMethodInfoPtr_OnElementEnable_Private_Void_KeyValuePair_2_Int32_NPCMusicRank_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663770);
			MusicRankPannel.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663771);
			MusicRankPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663772);
			MusicRankPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663773);
			MusicRankPannel.NativeMethodInfoPtr_ProcessRankElementShared_Private_Void_NPCMusicRank_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663774);
			MusicRankPannel.NativeMethodInfoPtr_ProcessTopRankElement_Private_Void_UIElementCluster_KeyValuePair_2_Int32_NPCMusicRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663775);
			MusicRankPannel.NativeMethodInfoPtr_ProcessNormalRankElement_Private_Void_UIElementCluster_KeyValuePair_2_Int32_NPCMusicRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663776);
			MusicRankPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663777);
			MusicRankPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663778);
			MusicRankPannel.NativeMethodInfoPtr__OnPanelInitialize_b__24_0_Private_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663779);
			MusicRankPannel.NativeMethodInfoPtr__OnElementEnable_b__25_0_Private_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663780);
			MusicRankPannel.NativeMethodInfoPtr__OnClose_b__26_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663781);
			MusicRankPannel.NativeMethodInfoPtr_Method_Private_Int32_NPCMusicRank_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663782);
			MusicRankPannel.NativeMethodInfoPtr__OnPanelOpen_b__27_1_Private_Boolean_NPCMusicRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, 100663783);
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000324 RID: 804 RVA: 0x000A9018 File Offset: 0x000A7218
		// (set) Token: 0x06000325 RID: 805 RVA: 0x000A9050 File Offset: 0x000A7250
		public unsafe MusicResultPannel.MusicFinalScoreOpenContext OpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.NativeMethodInfoPtr_get_OpenContext_Private_get_MusicFinalScoreOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new MusicResultPannel.MusicFinalScoreOpenContext(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21430, XrefRangeEnd = 21431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_MusicFinalScoreOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000326 RID: 806 RVA: 0x000A9098 File Offset: 0x000A7298
		// (set) Token: 0x06000327 RID: 807 RVA: 0x000A90D4 File Offset: 0x000A72D4
		public unsafe bool HasContinueButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.NativeMethodInfoPtr_get_HasContinueButton_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.NativeMethodInfoPtr_set_HasContinueButton_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000328 RID: 808 RVA: 0x000A9114 File Offset: 0x000A7314
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicRankPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000A915C File Offset: 0x000A735C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21431, XrefRangeEnd = 21501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicRankPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x000A9198 File Offset: 0x000A7398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21501, XrefRangeEnd = 21541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementEnable(KeyValuePair<int, MusicGameChapterProfile.NPCMusicRank> data, UIElementCluster ui, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ui);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.NativeMethodInfoPtr_OnElementEnable_Private_Void_KeyValuePair_2_Int32_NPCMusicRank_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000A9204 File Offset: 0x000A7404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21541, XrefRangeEnd = 21553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000A9238 File Offset: 0x000A7438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21553, XrefRangeEnd = 21667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicRankPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x000A9274 File Offset: 0x000A7474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21667, XrefRangeEnd = 21675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicRankPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000A92B0 File Offset: 0x000A74B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 21804, RefRangeEnd = 21807, XrefRangeStart = 21675, XrefRangeEnd = 21804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessRankElementShared(MusicGameChapterProfile.NPCMusicRank data, UIElementCluster cluster)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.NativeMethodInfoPtr_ProcessRankElementShared_Private_Void_NPCMusicRank_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x000A930C File Offset: 0x000A750C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21807, XrefRangeEnd = 21815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTopRankElement(UIElementCluster cluster, KeyValuePair<int, MusicGameChapterProfile.NPCMusicRank> dataPair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataPair));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.NativeMethodInfoPtr_ProcessTopRankElement_Private_Void_UIElementCluster_KeyValuePair_2_Int32_NPCMusicRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000A9368 File Offset: 0x000A7568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21815, XrefRangeEnd = 21827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessNormalRankElement(UIElementCluster cluster, KeyValuePair<int, MusicGameChapterProfile.NPCMusicRank> dataPair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataPair));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.NativeMethodInfoPtr_ProcessNormalRankElement_Private_Void_UIElementCluster_KeyValuePair_2_Int32_NPCMusicRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x000A93C4 File Offset: 0x000A75C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21827, XrefRangeEnd = 21838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicRankPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000A9400 File Offset: 0x000A7600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21838, XrefRangeEnd = 21841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicRankPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000A943C File Offset: 0x000A763C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21841, XrefRangeEnd = 21844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__24_0(MoveDirection dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.NativeMethodInfoPtr__OnPanelInitialize_b__24_0_Private_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000A947C File Offset: 0x000A767C
		[CallerCount(0)]
		public unsafe void _OnElementEnable_b__25_0(MoveDirection dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.NativeMethodInfoPtr__OnElementEnable_b__25_0_Private_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000A94BC File Offset: 0x000A76BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21844, XrefRangeEnd = 21852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnClose_b__26_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.NativeMethodInfoPtr__OnClose_b__26_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000A94F0 File Offset: 0x000A76F0
		[CallerCount(0)]
		public unsafe int Method_Private_Int32_NPCMusicRank_PDM_0(MusicGameChapterProfile.NPCMusicRank nPC)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(nPC));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.NativeMethodInfoPtr_Method_Private_Int32_NPCMusicRank_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000A9544 File Offset: 0x000A7744
		[CallerCount(0)]
		public unsafe bool _OnPanelOpen_b__27_1(MusicGameChapterProfile.NPCMusicRank x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.NativeMethodInfoPtr__OnPanelOpen_b__27_1_Private_Boolean_NPCMusicRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00003B90 File Offset: 0x00001D90
		public MusicRankPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000339 RID: 825 RVA: 0x000A9598 File Offset: 0x000A7798
		// (set) Token: 0x0600033A RID: 826 RVA: 0x00003B99 File Offset: 0x00001D99
		public unsafe static string SELF_TOP_INDICATOR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MusicRankPannel.NativeFieldInfoPtr_SELF_TOP_INDICATOR, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicRankPannel.NativeFieldInfoPtr_SELF_TOP_INDICATOR, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600033B RID: 827 RVA: 0x000A95B8 File Offset: 0x000A77B8
		// (set) Token: 0x0600033C RID: 828 RVA: 0x00003BAB File Offset: 0x00001DAB
		public unsafe static string SELF_INDICATOR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MusicRankPannel.NativeFieldInfoPtr_SELF_INDICATOR, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicRankPannel.NativeFieldInfoPtr_SELF_INDICATOR, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600033D RID: 829 RVA: 0x000A95D8 File Offset: 0x000A77D8
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00003BBD File Offset: 0x00001DBD
		public unsafe static string INPUTHELPER_CONTINUE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MusicRankPannel.NativeFieldInfoPtr_INPUTHELPER_CONTINUE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicRankPannel.NativeFieldInfoPtr_INPUTHELPER_CONTINUE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600033F RID: 831 RVA: 0x000A95F8 File Offset: 0x000A77F8
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00003BCF File Offset: 0x00001DCF
		public unsafe static string INPUTHELPER_BACK
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MusicRankPannel.NativeFieldInfoPtr_INPUTHELPER_BACK, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicRankPannel.NativeFieldInfoPtr_INPUTHELPER_BACK, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000341 RID: 833 RVA: 0x000A9618 File Offset: 0x000A7818
		// (set) Token: 0x06000342 RID: 834 RVA: 0x00003BE1 File Offset: 0x00001DE1
		public unsafe GameObject AIORankElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_AIORankElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_AIORankElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000343 RID: 835 RVA: 0x000A9648 File Offset: 0x000A7848
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00003C00 File Offset: 0x00001E00
		public unsafe ShapedLayoutGroup RankTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_RankTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShapedLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_RankTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000345 RID: 837 RVA: 0x000A9678 File Offset: 0x000A7878
		// (set) Token: 0x06000346 RID: 838 RVA: 0x00003C1F File Offset: 0x00001E1F
		public unsafe UIButtonSimple Btn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_Btn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_Btn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000347 RID: 839 RVA: 0x000A96A8 File Offset: 0x000A78A8
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00003C3E File Offset: 0x00001E3E
		public unsafe TextMeshProUGUI BtnText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_BtnText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_BtnText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000349 RID: 841 RVA: 0x000A96D8 File Offset: 0x000A78D8
		// (set) Token: 0x0600034A RID: 842 RVA: 0x00003C5D File Offset: 0x00001E5D
		public unsafe UIElementCluster CDComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_CDComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_CDComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600034B RID: 843 RVA: 0x000A9708 File Offset: 0x000A7908
		// (set) Token: 0x0600034C RID: 844 RVA: 0x00003C7C File Offset: 0x00001E7C
		public unsafe Sprite Top1RankSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_Top1RankSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_Top1RankSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600034D RID: 845 RVA: 0x000A9738 File Offset: 0x000A7938
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00003C9B File Offset: 0x00001E9B
		public unsafe Sprite Top2RankSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_Top2RankSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_Top2RankSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600034F RID: 847 RVA: 0x000A9768 File Offset: 0x000A7968
		// (set) Token: 0x06000350 RID: 848 RVA: 0x00003CBA File Offset: 0x00001EBA
		public unsafe Sprite Top3RankSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_Top3RankSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_Top3RankSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000351 RID: 849 RVA: 0x000A9798 File Offset: 0x000A7998
		// (set) Token: 0x06000352 RID: 850 RVA: 0x00003CD9 File Offset: 0x00001ED9
		public unsafe StaticVirtualScrollListUILogicalGroupT<KeyValuePair<int, MusicGameChapterProfile.NPCMusicRank>, UIElementCluster, UIButtonSimple> m_List
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_m_List);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVirtualScrollListUILogicalGroupT<KeyValuePair<int, MusicGameChapterProfile.NPCMusicRank>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_m_List), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000353 RID: 851 RVA: 0x000A97C8 File Offset: 0x000A79C8
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00003CF8 File Offset: 0x00001EF8
		public unsafe Il2CppReferenceArray<Sprite> m_TopRankSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_m_TopRankSprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr_m_TopRankSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000355 RID: 853 RVA: 0x000A97F8 File Offset: 0x000A79F8
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00003D17 File Offset: 0x00001F17
		public MusicResultPannel.MusicFinalScoreOpenContext _OpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr__OpenContext_k__BackingField);
				return new MusicResultPannel.MusicFinalScoreOpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicResultPannel.MusicFinalScoreOpenContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr__OpenContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MusicResultPannel.MusicFinalScoreOpenContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000357 RID: 855 RVA: 0x000A9828 File Offset: 0x000A7A28
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00003D45 File Offset: 0x00001F45
		public unsafe bool _HasContinueButton_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr__HasContinueButton_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.NativeFieldInfoPtr__HasContinueButton_k__BackingField)) = value;
			}
		}

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr_SELF_TOP_INDICATOR;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr_SELF_INDICATOR;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr_INPUTHELPER_CONTINUE;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_INPUTHELPER_BACK;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_AIORankElement;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_RankTransform;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_Btn;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr_BtnText;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_CDComponent;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_Top1RankSprite;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_Top2RankSprite;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_Top3RankSprite;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr_m_List;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_m_TopRankSprites;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeFieldInfoPtr__OpenContext_k__BackingField;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeFieldInfoPtr__HasContinueButton_k__BackingField;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Private_get_MusicFinalScoreOpenContext_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContext_Public_set_Void_MusicFinalScoreOpenContext_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_get_HasContinueButton_Private_get_Boolean_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_set_HasContinueButton_Public_set_Void_Boolean_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_OnElementEnable_Private_Void_KeyValuePair_2_Int32_NPCMusicRank_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRankElementShared_Private_Void_NPCMusicRank_UIElementCluster_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTopRankElement_Private_Void_UIElementCluster_KeyValuePair_2_Int32_NPCMusicRank_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_ProcessNormalRankElement_Private_Void_UIElementCluster_KeyValuePair_2_Int32_NPCMusicRank_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__24_0_Private_Void_MoveDirection_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr__OnElementEnable_b__25_0_Private_Void_MoveDirection_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr__OnClose_b__26_0_Private_Void_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Int32_NPCMusicRank_PDM_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__27_1_Private_Boolean_NPCMusicRank_0;

		// Token: 0x02000496 RID: 1174
		[ObfuscatedName("MusicGame.UI.MusicRankPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06007DF2 RID: 32242 RVA: 0x0023F328 File Offset: 0x0023D528
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MusicRankPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicRankPannel.__c>.NativeClassPtr);
				MusicRankPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel.__c>.NativeClassPtr, "<>9");
				MusicRankPannel.__c.NativeFieldInfoPtr___9__24_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel.__c>.NativeClassPtr, "<>9__24_1");
				MusicRankPannel.__c.NativeFieldInfoPtr___9__27_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel.__c>.NativeClassPtr, "<>9__27_2");
				MusicRankPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel.__c>.NativeClassPtr, 100663785);
				MusicRankPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__24_1_Internal_Void_KeyValuePair_2_Int32_NPCMusicRank_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel.__c>.NativeClassPtr, 100663786);
				MusicRankPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__27_2_Internal_Boolean_KeyValuePair_2_Int32_NPCMusicRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel.__c>.NativeClassPtr, 100663787);
			}

			// Token: 0x06007DF3 RID: 32243 RVA: 0x0023F3CC File Offset: 0x0023D5CC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicRankPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DF4 RID: 32244 RVA: 0x0023F408 File Offset: 0x0023D608
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__24_1(KeyValuePair<int, MusicGameChapterProfile.NPCMusicRank> _, UIElementCluster _, UIButtonSimple _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__24_1_Internal_Void_KeyValuePair_2_Int32_NPCMusicRank_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DF5 RID: 32245 RVA: 0x0023F474 File Offset: 0x0023D674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21426, XrefRangeEnd = 21430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__27_2(KeyValuePair<int, MusicGameChapterProfile.NPCMusicRank> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__27_2_Internal_Boolean_KeyValuePair_2_Int32_NPCMusicRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007DF6 RID: 32246 RVA: 0x00043CA0 File Offset: 0x00041EA0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A91 RID: 10897
			// (get) Token: 0x06007DF7 RID: 32247 RVA: 0x0023F4C8 File Offset: 0x0023D6C8
			// (set) Token: 0x06007DF8 RID: 32248 RVA: 0x00043CA9 File Offset: 0x00041EA9
			public unsafe static MusicRankPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicRankPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicRankPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicRankPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A92 RID: 10898
			// (get) Token: 0x06007DF9 RID: 32249 RVA: 0x0023F4F0 File Offset: 0x0023D6F0
			// (set) Token: 0x06007DFA RID: 32250 RVA: 0x00043CBB File Offset: 0x00041EBB
			public unsafe static Action<KeyValuePair<int, MusicGameChapterProfile.NPCMusicRank>, UIElementCluster, UIButtonSimple> __9__24_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicRankPannel.__c.NativeFieldInfoPtr___9__24_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<int, MusicGameChapterProfile.NPCMusicRank>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicRankPannel.__c.NativeFieldInfoPtr___9__24_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A93 RID: 10899
			// (get) Token: 0x06007DFB RID: 32251 RVA: 0x0023F518 File Offset: 0x0023D718
			// (set) Token: 0x06007DFC RID: 32252 RVA: 0x00043CCD File Offset: 0x00041ECD
			public unsafe static Predicate<KeyValuePair<int, MusicGameChapterProfile.NPCMusicRank>> __9__27_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicRankPannel.__c.NativeFieldInfoPtr___9__27_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<KeyValuePair<int, MusicGameChapterProfile.NPCMusicRank>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicRankPannel.__c.NativeFieldInfoPtr___9__27_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040052DA RID: 21210
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040052DB RID: 21211
			private static readonly IntPtr NativeFieldInfoPtr___9__24_1;

			// Token: 0x040052DC RID: 21212
			private static readonly IntPtr NativeFieldInfoPtr___9__27_2;

			// Token: 0x040052DD RID: 21213
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040052DE RID: 21214
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__24_1_Internal_Void_KeyValuePair_2_Int32_NPCMusicRank_UIElementCluster_UIButtonSimple_0;

			// Token: 0x040052DF RID: 21215
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__27_2_Internal_Boolean_KeyValuePair_2_Int32_NPCMusicRank_0;
		}

		// Token: 0x02000497 RID: 1175
		[ObfuscatedName("MusicGame.UI.MusicRankPannel+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x06007DFD RID: 32253 RVA: 0x0023F540 File Offset: 0x0023D740
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<MusicRankPannel.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicRankPannel.__c__DisplayClass29_0>.NativeClassPtr);
				MusicRankPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_selfVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel.__c__DisplayClass29_0>.NativeClassPtr, "selfVisual");
				MusicRankPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel.__c__DisplayClass29_0>.NativeClassPtr, 100663788);
				MusicRankPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__ProcessRankElementShared_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel.__c__DisplayClass29_0>.NativeClassPtr, 100663789);
				MusicRankPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__ProcessRankElementShared_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel.__c__DisplayClass29_0>.NativeClassPtr, 100663790);
			}

			// Token: 0x06007DFE RID: 32254 RVA: 0x0023F5BC File Offset: 0x0023D7BC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicRankPannel.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DFF RID: 32255 RVA: 0x0023F5F8 File Offset: 0x0023D7F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessRankElementShared_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__ProcessRankElementShared_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E00 RID: 32256 RVA: 0x0023F63C File Offset: 0x0023D83C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessRankElementShared_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__ProcessRankElementShared_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E01 RID: 32257 RVA: 0x00043CDF File Offset: 0x00041EDF
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A94 RID: 10900
			// (get) Token: 0x06007E02 RID: 32258 RVA: 0x0023F680 File Offset: 0x0023D880
			// (set) Token: 0x06007E03 RID: 32259 RVA: 0x00043CE8 File Offset: 0x00041EE8
			public unsafe CharacterSpriteSetFull selfVisual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_selfVisual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetFull>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_selfVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040052E0 RID: 21216
			private static readonly IntPtr NativeFieldInfoPtr_selfVisual;

			// Token: 0x040052E1 RID: 21217
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040052E2 RID: 21218
			private static readonly IntPtr NativeMethodInfoPtr__ProcessRankElementShared_b__0_Internal_Void_Image_0;

			// Token: 0x040052E3 RID: 21219
			private static readonly IntPtr NativeMethodInfoPtr__ProcessRankElementShared_b__1_Internal_Void_Image_0;
		}

		// Token: 0x02000498 RID: 1176
		[ObfuscatedName("MusicGame.UI.MusicRankPannel+<>c__DisplayClass29_1")]
		public sealed class __c__DisplayClass29_1 : Il2CppSystem.Object
		{
			// Token: 0x06007E04 RID: 32260 RVA: 0x0023F6B0 File Offset: 0x0023D8B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_1()
			{
				Il2CppClassPointerStore<MusicRankPannel.__c__DisplayClass29_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicRankPannel>.NativeClassPtr, "<>c__DisplayClass29_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicRankPannel.__c__DisplayClass29_1>.NativeClassPtr);
				MusicRankPannel.__c__DisplayClass29_1.NativeFieldInfoPtr_npcVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicRankPannel.__c__DisplayClass29_1>.NativeClassPtr, "npcVisual");
				MusicRankPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel.__c__DisplayClass29_1>.NativeClassPtr, 100663791);
				MusicRankPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__ProcessRankElementShared_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel.__c__DisplayClass29_1>.NativeClassPtr, 100663792);
				MusicRankPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__ProcessRankElementShared_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicRankPannel.__c__DisplayClass29_1>.NativeClassPtr, 100663793);
			}

			// Token: 0x06007E05 RID: 32261 RVA: 0x0023F72C File Offset: 0x0023D92C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicRankPannel.__c__DisplayClass29_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E06 RID: 32262 RVA: 0x0023F768 File Offset: 0x0023D968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessRankElementShared_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__ProcessRankElementShared_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E07 RID: 32263 RVA: 0x0023F7AC File Offset: 0x0023D9AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessRankElementShared_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicRankPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__ProcessRankElementShared_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E08 RID: 32264 RVA: 0x00043D07 File Offset: 0x00041F07
			public __c__DisplayClass29_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A95 RID: 10901
			// (get) Token: 0x06007E09 RID: 32265 RVA: 0x0023F7F0 File Offset: 0x0023D9F0
			// (set) Token: 0x06007E0A RID: 32266 RVA: 0x00043D10 File Offset: 0x00041F10
			public unsafe CharacterSpriteSetCompact npcVisual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.__c__DisplayClass29_1.NativeFieldInfoPtr_npcVisual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicRankPannel.__c__DisplayClass29_1.NativeFieldInfoPtr_npcVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040052E4 RID: 21220
			private static readonly IntPtr NativeFieldInfoPtr_npcVisual;

			// Token: 0x040052E5 RID: 21221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040052E6 RID: 21222
			private static readonly IntPtr NativeMethodInfoPtr__ProcessRankElementShared_b__2_Internal_Void_Image_0;

			// Token: 0x040052E7 RID: 21223
			private static readonly IntPtr NativeMethodInfoPtr__ProcessRankElementShared_b__3_Internal_Void_Image_0;
		}
	}
}
