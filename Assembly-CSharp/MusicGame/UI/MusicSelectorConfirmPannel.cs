using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MusicGame.UI
{
	// Token: 0x02000029 RID: 41
	public class MusicSelectorConfirmPannel : UISubPanel<MusicSelectorPannel>
	{
		// Token: 0x060003DC RID: 988 RVA: 0x000AAF6C File Offset: 0x000A916C
		// Note: this type is marked as 'beforefieldinit'.
		static MusicSelectorConfirmPannel()
		{
			Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "MusicSelectorConfirmPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr);
			MusicSelectorConfirmPannel.NativeFieldInfoPtr_m_EasyModeStartButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, "m_EasyModeStartButton");
			MusicSelectorConfirmPannel.NativeFieldInfoPtr_m_HardModeStartButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, "m_HardModeStartButton");
			MusicSelectorConfirmPannel.NativeFieldInfoPtr_m_EasyModeRankButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, "m_EasyModeRankButton");
			MusicSelectorConfirmPannel.NativeFieldInfoPtr_m_HardModeRankButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, "m_HardModeRankButton");
			MusicSelectorConfirmPannel.NativeFieldInfoPtr_m_MusicSelectorReconfirmPannelPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, "m_MusicSelectorReconfirmPannelPrefab");
			MusicSelectorConfirmPannel.NativeFieldInfoPtr__OpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, "<OpenContext>k__BackingField");
			MusicSelectorConfirmPannel.NativeFieldInfoPtr__DifficultyMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, "<DifficultyMode>k__BackingField");
			MusicSelectorConfirmPannel.NativeFieldInfoPtr__PlayMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, "<PlayMode>k__BackingField");
			MusicSelectorConfirmPannel.NativeFieldInfoPtr__MusicalNoteSpeed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, "<MusicalNoteSpeed>k__BackingField");
			MusicSelectorConfirmPannel.NativeMethodInfoPtr_get_OpenContext_Public_get_MusicSelectorConfirmPannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663845);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_MusicSelectorConfirmPannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663846);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr_get_DifficultyMode_Public_get_DifficultyMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663847);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr_set_DifficultyMode_Private_set_Void_DifficultyMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663848);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr_get_PlayMode_Public_get_PlayMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663849);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr_set_PlayMode_Private_set_Void_PlayMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663850);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr_get_MusicalNoteSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663851);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr_set_MusicalNoteSpeed_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663852);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663853);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663854);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663855);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr_SetRankButton_Public_Void_String_Action_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663856);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr_Confirm_Private_Void_DifficultyMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663857);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr_OnReconfirmPannelClose_Private_Void_MusicSelectorReconfirmPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663858);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663859);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663860);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr__OnPanelOpen_b__24_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663861);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr__OnPanelOpen_b__24_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663862);
			MusicSelectorConfirmPannel.NativeMethodInfoPtr__Confirm_b__26_0_Private_Void_MusicSelectorReconfirmPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, 100663863);
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060003DD RID: 989 RVA: 0x000AB1CC File Offset: 0x000A93CC
		// (set) Token: 0x060003DE RID: 990 RVA: 0x000AB204 File Offset: 0x000A9404
		public unsafe MusicSelectorConfirmPannelOpenContext OpenContext
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22275, RefRangeEnd = 22276, XrefRangeStart = 22275, XrefRangeEnd = 22275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.NativeMethodInfoPtr_get_OpenContext_Public_get_MusicSelectorConfirmPannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new MusicSelectorConfirmPannelOpenContext(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22276, XrefRangeEnd = 22277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_MusicSelectorConfirmPannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060003DF RID: 991 RVA: 0x000AB24C File Offset: 0x000A944C
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x000AB288 File Offset: 0x000A9488
		public unsafe DifficultyMode DifficultyMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.NativeMethodInfoPtr_get_DifficultyMode_Public_get_DifficultyMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.NativeMethodInfoPtr_set_DifficultyMode_Private_set_Void_DifficultyMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x000AB2C8 File Offset: 0x000A94C8
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x000AB304 File Offset: 0x000A9504
		public unsafe PlayMode PlayMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.NativeMethodInfoPtr_get_PlayMode_Public_get_PlayMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.NativeMethodInfoPtr_set_PlayMode_Private_set_Void_PlayMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x000AB344 File Offset: 0x000A9544
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x000AB380 File Offset: 0x000A9580
		public unsafe float MusicalNoteSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.NativeMethodInfoPtr_get_MusicalNoteSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.NativeMethodInfoPtr_set_MusicalNoteSpeed_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x000AB3C0 File Offset: 0x000A95C0
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorConfirmPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000AB408 File Offset: 0x000A9608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22277, XrefRangeEnd = 22282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorConfirmPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000AB444 File Offset: 0x000A9644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22282, XrefRangeEnd = 22296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorConfirmPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000AB480 File Offset: 0x000A9680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22296, XrefRangeEnd = 22316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRankButton(string mapLabel, Action<string, bool> openRankCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(openRankCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.NativeMethodInfoPtr_SetRankButton_Public_Void_String_Action_2_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000AB4D4 File Offset: 0x000A96D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 22336, RefRangeEnd = 22338, XrefRangeStart = 22316, XrefRangeEnd = 22336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Confirm(DifficultyMode difficultyMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref difficultyMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.NativeMethodInfoPtr_Confirm_Private_Void_DifficultyMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000AB514 File Offset: 0x000A9714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22338, XrefRangeEnd = 22341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnReconfirmPannelClose(MusicSelectorReconfirmPannel pannel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pannel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.NativeMethodInfoPtr_OnReconfirmPannelClose_Private_Void_MusicSelectorReconfirmPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000AB558 File Offset: 0x000A9758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22341, XrefRangeEnd = 22347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicSelectorConfirmPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000AB594 File Offset: 0x000A9794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22347, XrefRangeEnd = 22350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicSelectorConfirmPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000AB5D0 File Offset: 0x000A97D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22350, XrefRangeEnd = 22351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__24_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.NativeMethodInfoPtr__OnPanelOpen_b__24_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000AB604 File Offset: 0x000A9804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22351, XrefRangeEnd = 22352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__24_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.NativeMethodInfoPtr__OnPanelOpen_b__24_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000AB638 File Offset: 0x000A9838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22352, XrefRangeEnd = 22354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Confirm_b__26_0(MusicSelectorReconfirmPannel reconfirmPannel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reconfirmPannel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.NativeMethodInfoPtr__Confirm_b__26_0_Private_Void_MusicSelectorReconfirmPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000042EF File Offset: 0x000024EF
		public MusicSelectorConfirmPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000AB67C File Offset: 0x000A987C
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x000042F8 File Offset: 0x000024F8
		public unsafe UIButtonSimple m_EasyModeStartButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr_m_EasyModeStartButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr_m_EasyModeStartButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x000AB6AC File Offset: 0x000A98AC
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00004317 File Offset: 0x00002517
		public unsafe UIButtonSimple m_HardModeStartButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr_m_HardModeStartButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr_m_HardModeStartButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x000AB6DC File Offset: 0x000A98DC
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00004336 File Offset: 0x00002536
		public unsafe UIButtonSimple m_EasyModeRankButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr_m_EasyModeRankButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr_m_EasyModeRankButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x000AB70C File Offset: 0x000A990C
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00004355 File Offset: 0x00002555
		public unsafe UIButtonSimple m_HardModeRankButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr_m_HardModeRankButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr_m_HardModeRankButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x000AB73C File Offset: 0x000A993C
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x00004374 File Offset: 0x00002574
		public unsafe MusicSelectorReconfirmPannel m_MusicSelectorReconfirmPannelPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr_m_MusicSelectorReconfirmPannelPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSelectorReconfirmPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr_m_MusicSelectorReconfirmPannelPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x000AB76C File Offset: 0x000A996C
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00004393 File Offset: 0x00002593
		public MusicSelectorConfirmPannelOpenContext _OpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr__OpenContext_k__BackingField);
				return new MusicSelectorConfirmPannelOpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicSelectorConfirmPannelOpenContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr__OpenContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MusicSelectorConfirmPannelOpenContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x000AB79C File Offset: 0x000A999C
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x000043C1 File Offset: 0x000025C1
		public unsafe DifficultyMode _DifficultyMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr__DifficultyMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr__DifficultyMode_k__BackingField)) = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x000AB7C4 File Offset: 0x000A99C4
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x000043DC File Offset: 0x000025DC
		public unsafe PlayMode _PlayMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr__PlayMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr__PlayMode_k__BackingField)) = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x000AB7EC File Offset: 0x000A99EC
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x000043F7 File Offset: 0x000025F7
		public unsafe float _MusicalNoteSpeed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr__MusicalNoteSpeed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.NativeFieldInfoPtr__MusicalNoteSpeed_k__BackingField)) = value;
			}
		}

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeFieldInfoPtr_m_EasyModeStartButton;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeFieldInfoPtr_m_HardModeStartButton;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr_m_EasyModeRankButton;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeFieldInfoPtr_m_HardModeRankButton;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicSelectorReconfirmPannelPrefab;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeFieldInfoPtr__OpenContext_k__BackingField;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeFieldInfoPtr__DifficultyMode_k__BackingField;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr__PlayMode_k__BackingField;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeFieldInfoPtr__MusicalNoteSpeed_k__BackingField;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Public_get_MusicSelectorConfirmPannelOpenContext_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContext_Public_set_Void_MusicSelectorConfirmPannelOpenContext_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_get_DifficultyMode_Public_get_DifficultyMode_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_set_DifficultyMode_Private_set_Void_DifficultyMode_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayMode_Public_get_PlayMode_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayMode_Private_set_Void_PlayMode_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_get_MusicalNoteSpeed_Public_get_Single_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_set_MusicalNoteSpeed_Private_set_Void_Single_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_SetRankButton_Public_Void_String_Action_2_String_Boolean_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_Confirm_Private_Void_DifficultyMode_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_OnReconfirmPannelClose_Private_Void_MusicSelectorReconfirmPannel_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__24_0_Private_Void_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__24_1_Private_Void_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr__Confirm_b__26_0_Private_Void_MusicSelectorReconfirmPannel_0;

		// Token: 0x0200049D RID: 1181
		[ObfuscatedName("MusicGame.UI.MusicSelectorConfirmPannel+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Object
		{
			// Token: 0x06007E4C RID: 32332 RVA: 0x002403B8 File Offset: 0x0023E5B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<MusicSelectorConfirmPannel.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicSelectorConfirmPannel>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicSelectorConfirmPannel.__c__DisplayClass25_0>.NativeClassPtr);
				MusicSelectorConfirmPannel.__c__DisplayClass25_0.NativeFieldInfoPtr_openRankCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorConfirmPannel.__c__DisplayClass25_0>.NativeClassPtr, "openRankCallback");
				MusicSelectorConfirmPannel.__c__DisplayClass25_0.NativeFieldInfoPtr_mapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicSelectorConfirmPannel.__c__DisplayClass25_0>.NativeClassPtr, "mapLabel");
				MusicSelectorConfirmPannel.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel.__c__DisplayClass25_0>.NativeClassPtr, 100663864);
				MusicSelectorConfirmPannel.__c__DisplayClass25_0.NativeMethodInfoPtr__SetRankButton_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel.__c__DisplayClass25_0>.NativeClassPtr, 100663865);
				MusicSelectorConfirmPannel.__c__DisplayClass25_0.NativeMethodInfoPtr__SetRankButton_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicSelectorConfirmPannel.__c__DisplayClass25_0>.NativeClassPtr, 100663866);
			}

			// Token: 0x06007E4D RID: 32333 RVA: 0x00240448 File Offset: 0x0023E648
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicSelectorConfirmPannel.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E4E RID: 32334 RVA: 0x00240484 File Offset: 0x0023E684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22273, XrefRangeEnd = 22274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetRankButton_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.__c__DisplayClass25_0.NativeMethodInfoPtr__SetRankButton_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E4F RID: 32335 RVA: 0x002404B8 File Offset: 0x0023E6B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22274, XrefRangeEnd = 22275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetRankButton_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicSelectorConfirmPannel.__c__DisplayClass25_0.NativeMethodInfoPtr__SetRankButton_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E50 RID: 32336 RVA: 0x00043F82 File Offset: 0x00042182
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002AAD RID: 10925
			// (get) Token: 0x06007E51 RID: 32337 RVA: 0x002404EC File Offset: 0x0023E6EC
			// (set) Token: 0x06007E52 RID: 32338 RVA: 0x00043F8B File Offset: 0x0004218B
			public unsafe Action<string, bool> openRankCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.__c__DisplayClass25_0.NativeFieldInfoPtr_openRankCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.__c__DisplayClass25_0.NativeFieldInfoPtr_openRankCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AAE RID: 10926
			// (get) Token: 0x06007E53 RID: 32339 RVA: 0x0024051C File Offset: 0x0023E71C
			// (set) Token: 0x06007E54 RID: 32340 RVA: 0x00043FAA File Offset: 0x000421AA
			public unsafe string mapLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.__c__DisplayClass25_0.NativeFieldInfoPtr_mapLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicSelectorConfirmPannel.__c__DisplayClass25_0.NativeFieldInfoPtr_mapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400530D RID: 21261
			private static readonly IntPtr NativeFieldInfoPtr_openRankCallback;

			// Token: 0x0400530E RID: 21262
			private static readonly IntPtr NativeFieldInfoPtr_mapLabel;

			// Token: 0x0400530F RID: 21263
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005310 RID: 21264
			private static readonly IntPtr NativeMethodInfoPtr__SetRankButton_b__0_Internal_Void_0;

			// Token: 0x04005311 RID: 21265
			private static readonly IntPtr NativeMethodInfoPtr__SetRankButton_b__1_Internal_Void_0;
		}
	}
}
