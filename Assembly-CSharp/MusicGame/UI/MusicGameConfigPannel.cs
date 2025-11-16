using System;
using Common.UI.EscapeUtility;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;

namespace MusicGame.UI
{
	// Token: 0x02000026 RID: 38
	public class MusicGameConfigPannel : UISubPanel<MusicSelectorReconfirmPannel>
	{
		// Token: 0x0600039E RID: 926 RVA: 0x000AA584 File Offset: 0x000A8784
		// Note: this type is marked as 'beforefieldinit'.
		static MusicGameConfigPannel()
		{
			Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "MusicGameConfigPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr);
			MusicGameConfigPannel.NativeFieldInfoPtr_MUSICGAME_QTEFIELD_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "MUSICGAME_QTEFIELD_LENGTH");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_MusicVolume");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicVolumePercentageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_MusicVolumePercentageText");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_ButtonVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_ButtonVolume");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_ButtonVolumePercentageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_ButtonVolumePercentageText");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicCalibration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_MusicCalibration");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicCalibrationText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_MusicCalibrationText");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicalNoteSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_MusicalNoteSpeed");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicalNoteSpeedPercentageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_MusicalNoteSpeedPercentageText");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_GoBackBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_GoBackBtn");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_NoteSimple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_NoteSimple");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_NoteField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_NoteField");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_BindingSettingParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_BindingSettingParent");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_BindingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_BindingField");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_InputBindingDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_InputBindingDatas");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_Groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_Groups");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_AllChildrenInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_AllChildrenInstances");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_AllGameObjectInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_AllGameObjectInstances");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_Instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_Instances");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_CallbackInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_CallbackInitialized");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_OnUpdatePreviewLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_OnUpdatePreviewLoop");
			MusicGameConfigPannel.NativeFieldInfoPtr_m_QTESpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "m_QTESpeedMultiplier");
			MusicGameConfigPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, 100663828);
			MusicGameConfigPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, 100663829);
			MusicGameConfigPannel.NativeMethodInfoPtr_OnUpdatePreview_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, 100663830);
			MusicGameConfigPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, 100663831);
			MusicGameConfigPannel.NativeMethodInfoPtr_OnMusicalNoteSpeedChangedVisual_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, 100663832);
			MusicGameConfigPannel.NativeMethodInfoPtr_OnMusicCalibrationChangedVisual_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, 100663833);
			MusicGameConfigPannel.NativeMethodInfoPtr_OnMusicVolumeChangedVisual_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, 100663834);
			MusicGameConfigPannel.NativeMethodInfoPtr_OnButtonVolumeChangedVisual_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, 100663835);
			MusicGameConfigPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, 100663836);
			MusicGameConfigPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, 100663837);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000AA834 File Offset: 0x000A8A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22109, XrefRangeEnd = 22121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameConfigPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x000AA870 File Offset: 0x000A8A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22121, XrefRangeEnd = 22195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameConfigPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x000AA8AC File Offset: 0x000A8AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22195, XrefRangeEnd = 22200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnUpdatePreview()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameConfigPannel.NativeMethodInfoPtr_OnUpdatePreview_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000AA8EC File Offset: 0x000A8AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22200, XrefRangeEnd = 22206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameConfigPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000AA928 File Offset: 0x000A8B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22206, XrefRangeEnd = 22209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMusicalNoteSpeedChangedVisual(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameConfigPannel.NativeMethodInfoPtr_OnMusicalNoteSpeedChangedVisual_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x000AA968 File Offset: 0x000A8B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22209, XrefRangeEnd = 22211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMusicCalibrationChangedVisual(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameConfigPannel.NativeMethodInfoPtr_OnMusicCalibrationChangedVisual_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x000AA9A8 File Offset: 0x000A8BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22211, XrefRangeEnd = 22218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMusicVolumeChangedVisual(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameConfigPannel.NativeMethodInfoPtr_OnMusicVolumeChangedVisual_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000AA9E8 File Offset: 0x000A8BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22218, XrefRangeEnd = 22225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnButtonVolumeChangedVisual(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameConfigPannel.NativeMethodInfoPtr_OnButtonVolumeChangedVisual_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000AAA28 File Offset: 0x000A8C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22225, XrefRangeEnd = 22248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameConfigPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000AAA64 File Offset: 0x000A8C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22248, XrefRangeEnd = 22273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicGameConfigPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameConfigPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000401B File Offset: 0x0000221B
		public MusicGameConfigPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003AA RID: 938 RVA: 0x000AAAA0 File Offset: 0x000A8CA0
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00004024 File Offset: 0x00002224
		public unsafe static float MUSICGAME_QTEFIELD_LENGTH
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MusicGameConfigPannel.NativeFieldInfoPtr_MUSICGAME_QTEFIELD_LENGTH, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicGameConfigPannel.NativeFieldInfoPtr_MUSICGAME_QTEFIELD_LENGTH, (void*)(&value));
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003AC RID: 940 RVA: 0x000AAABC File Offset: 0x000A8CBC
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00004032 File Offset: 0x00002232
		public unsafe UIScrollBar m_MusicVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScrollBar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003AE RID: 942 RVA: 0x000AAAEC File Offset: 0x000A8CEC
		// (set) Token: 0x060003AF RID: 943 RVA: 0x00004051 File Offset: 0x00002251
		public unsafe TMP_Text m_MusicVolumePercentageText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicVolumePercentageText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicVolumePercentageText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x000AAB1C File Offset: 0x000A8D1C
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x00004070 File Offset: 0x00002270
		public unsafe UIScrollBar m_ButtonVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_ButtonVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScrollBar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_ButtonVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x000AAB4C File Offset: 0x000A8D4C
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x0000408F File Offset: 0x0000228F
		public unsafe TMP_Text m_ButtonVolumePercentageText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_ButtonVolumePercentageText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_ButtonVolumePercentageText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x000AAB7C File Offset: 0x000A8D7C
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x000040AE File Offset: 0x000022AE
		public unsafe UIScrollBar m_MusicCalibration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicCalibration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScrollBar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicCalibration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x000AABAC File Offset: 0x000A8DAC
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x000040CD File Offset: 0x000022CD
		public unsafe TMP_Text m_MusicCalibrationText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicCalibrationText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicCalibrationText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x000AABDC File Offset: 0x000A8DDC
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x000040EC File Offset: 0x000022EC
		public unsafe UIScrollBar m_MusicalNoteSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicalNoteSpeed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScrollBar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicalNoteSpeed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003BA RID: 954 RVA: 0x000AAC0C File Offset: 0x000A8E0C
		// (set) Token: 0x060003BB RID: 955 RVA: 0x0000410B File Offset: 0x0000230B
		public unsafe TMP_Text m_MusicalNoteSpeedPercentageText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicalNoteSpeedPercentageText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_MusicalNoteSpeedPercentageText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003BC RID: 956 RVA: 0x000AAC3C File Offset: 0x000A8E3C
		// (set) Token: 0x060003BD RID: 957 RVA: 0x0000412A File Offset: 0x0000232A
		public unsafe UIButtonSimple m_GoBackBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_GoBackBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_GoBackBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003BE RID: 958 RVA: 0x000AAC6C File Offset: 0x000A8E6C
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00004149 File Offset: 0x00002349
		public unsafe RectTransform m_NoteSimple
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_NoteSimple);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_NoteSimple), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x000AAC9C File Offset: 0x000A8E9C
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00004168 File Offset: 0x00002368
		public unsafe RectTransform m_NoteField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_NoteField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_NoteField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x000AACCC File Offset: 0x000A8ECC
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00004187 File Offset: 0x00002387
		public unsafe GameObject m_BindingSettingParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_BindingSettingParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_BindingSettingParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x000AACFC File Offset: 0x000A8EFC
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x000041A6 File Offset: 0x000023A6
		public unsafe RectTransform m_BindingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_BindingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_BindingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x000AAD2C File Offset: 0x000A8F2C
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x000041C5 File Offset: 0x000023C5
		public unsafe Il2CppReferenceArray<EscBindingPannel.InputBindingData> m_InputBindingDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_InputBindingDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EscBindingPannel.InputBindingData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_InputBindingDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x000AAD5C File Offset: 0x000A8F5C
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x000041E4 File Offset: 0x000023E4
		public unsafe Il2CppReferenceArray<EscBindingPannel.StringArray> m_Groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_Groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EscBindingPannel.StringArray>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_Groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003CA RID: 970 RVA: 0x000AAD8C File Offset: 0x000A8F8C
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00004203 File Offset: 0x00002403
		public unsafe UILogicalGroupT<string> m_AllChildrenInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_AllChildrenInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroupT<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_AllChildrenInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003CC RID: 972 RVA: 0x000AADBC File Offset: 0x000A8FBC
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00004222 File Offset: 0x00002422
		public unsafe List<GameObject> m_AllGameObjectInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_AllGameObjectInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_AllGameObjectInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003CE RID: 974 RVA: 0x000AADEC File Offset: 0x000A8FEC
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00004241 File Offset: 0x00002441
		public unsafe Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> m_Instances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_Instances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_Instances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x000AAE1C File Offset: 0x000A901C
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00004260 File Offset: 0x00002460
		public unsafe bool m_CallbackInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_CallbackInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_CallbackInitialized)) = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x000AAE44 File Offset: 0x000A9044
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x0000427B File Offset: 0x0000247B
		public unsafe Coroutine m_OnUpdatePreviewLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_OnUpdatePreviewLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_OnUpdatePreviewLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x000AAE74 File Offset: 0x000A9074
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x0000429A File Offset: 0x0000249A
		public unsafe float m_QTESpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_QTESpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel.NativeFieldInfoPtr_m_QTESpeedMultiplier)) = value;
			}
		}

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeFieldInfoPtr_MUSICGAME_QTEFIELD_LENGTH;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicVolume;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicVolumePercentageText;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeFieldInfoPtr_m_ButtonVolume;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeFieldInfoPtr_m_ButtonVolumePercentageText;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicCalibration;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicCalibrationText;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicalNoteSpeed;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeFieldInfoPtr_m_MusicalNoteSpeedPercentageText;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeFieldInfoPtr_m_GoBackBtn;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteSimple;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteField;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr_m_BindingSettingParent;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeFieldInfoPtr_m_BindingField;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeFieldInfoPtr_m_InputBindingDatas;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeFieldInfoPtr_m_Groups;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeFieldInfoPtr_m_AllChildrenInstances;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeFieldInfoPtr_m_AllGameObjectInstances;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeFieldInfoPtr_m_Instances;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeFieldInfoPtr_m_CallbackInitialized;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeFieldInfoPtr_m_OnUpdatePreviewLoop;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeFieldInfoPtr_m_QTESpeedMultiplier;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdatePreview_Private_IEnumerator_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_OnMusicalNoteSpeedChangedVisual_Private_Void_Single_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_OnMusicCalibrationChangedVisual_Private_Void_Single_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_OnMusicVolumeChangedVisual_Private_Void_Single_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonVolumeChangedVisual_Private_Void_Single_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200049C RID: 1180
		[ObfuscatedName("MusicGame.UI.MusicGameConfigPannel+<OnUpdatePreview>d__24")]
		public sealed class _OnUpdatePreview_d__24 : Il2CppSystem.Object
		{
			// Token: 0x06007E3A RID: 32314 RVA: 0x0024006C File Offset: 0x0023E26C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnUpdatePreview_d__24()
			{
				Il2CppClassPointerStore<MusicGameConfigPannel._OnUpdatePreview_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameConfigPannel>.NativeClassPtr, "<OnUpdatePreview>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameConfigPannel._OnUpdatePreview_d__24>.NativeClassPtr);
				MusicGameConfigPannel._OnUpdatePreview_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel._OnUpdatePreview_d__24>.NativeClassPtr, "<>1__state");
				MusicGameConfigPannel._OnUpdatePreview_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel._OnUpdatePreview_d__24>.NativeClassPtr, "<>2__current");
				MusicGameConfigPannel._OnUpdatePreview_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel._OnUpdatePreview_d__24>.NativeClassPtr, "<>4__this");
				MusicGameConfigPannel._OnUpdatePreview_d__24.NativeFieldInfoPtr__pos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel._OnUpdatePreview_d__24>.NativeClassPtr, "<pos>5__2");
				MusicGameConfigPannel._OnUpdatePreview_d__24.NativeFieldInfoPtr__progress_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameConfigPannel._OnUpdatePreview_d__24>.NativeClassPtr, "<progress>5__3");
				MusicGameConfigPannel._OnUpdatePreview_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameConfigPannel._OnUpdatePreview_d__24>.NativeClassPtr, 100663838);
				MusicGameConfigPannel._OnUpdatePreview_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameConfigPannel._OnUpdatePreview_d__24>.NativeClassPtr, 100663839);
				MusicGameConfigPannel._OnUpdatePreview_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameConfigPannel._OnUpdatePreview_d__24>.NativeClassPtr, 100663840);
				MusicGameConfigPannel._OnUpdatePreview_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameConfigPannel._OnUpdatePreview_d__24>.NativeClassPtr, 100663841);
				MusicGameConfigPannel._OnUpdatePreview_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameConfigPannel._OnUpdatePreview_d__24>.NativeClassPtr, 100663842);
				MusicGameConfigPannel._OnUpdatePreview_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameConfigPannel._OnUpdatePreview_d__24>.NativeClassPtr, 100663843);
			}

			// Token: 0x06007E3B RID: 32315 RVA: 0x00240174 File Offset: 0x0023E374
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnUpdatePreview_d__24(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameConfigPannel._OnUpdatePreview_d__24>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameConfigPannel._OnUpdatePreview_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E3C RID: 32316 RVA: 0x002401BC File Offset: 0x0023E3BC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameConfigPannel._OnUpdatePreview_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E3D RID: 32317 RVA: 0x002401F0 File Offset: 0x0023E3F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22093, XrefRangeEnd = 22103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameConfigPannel._OnUpdatePreview_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002AAB RID: 10923
			// (get) Token: 0x06007E3E RID: 32318 RVA: 0x0024022C File Offset: 0x0023E42C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameConfigPannel._OnUpdatePreview_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007E3F RID: 32319 RVA: 0x0024026C File Offset: 0x0023E46C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22103, XrefRangeEnd = 22109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameConfigPannel._OnUpdatePreview_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002AAC RID: 10924
			// (get) Token: 0x06007E40 RID: 32320 RVA: 0x002402A0 File Offset: 0x0023E4A0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameConfigPannel._OnUpdatePreview_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007E41 RID: 32321 RVA: 0x00043EEA File Offset: 0x000420EA
			public _OnUpdatePreview_d__24(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002AA6 RID: 10918
			// (get) Token: 0x06007E42 RID: 32322 RVA: 0x002402E0 File Offset: 0x0023E4E0
			// (set) Token: 0x06007E43 RID: 32323 RVA: 0x00043EF3 File Offset: 0x000420F3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel._OnUpdatePreview_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel._OnUpdatePreview_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002AA7 RID: 10919
			// (get) Token: 0x06007E44 RID: 32324 RVA: 0x00240308 File Offset: 0x0023E508
			// (set) Token: 0x06007E45 RID: 32325 RVA: 0x00043F0E File Offset: 0x0004210E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel._OnUpdatePreview_d__24.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel._OnUpdatePreview_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AA8 RID: 10920
			// (get) Token: 0x06007E46 RID: 32326 RVA: 0x00240338 File Offset: 0x0023E538
			// (set) Token: 0x06007E47 RID: 32327 RVA: 0x00043F2D File Offset: 0x0004212D
			public unsafe MusicGameConfigPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel._OnUpdatePreview_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameConfigPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel._OnUpdatePreview_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AA9 RID: 10921
			// (get) Token: 0x06007E48 RID: 32328 RVA: 0x00240368 File Offset: 0x0023E568
			// (set) Token: 0x06007E49 RID: 32329 RVA: 0x00043F4C File Offset: 0x0004214C
			public unsafe Vector2 _pos_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel._OnUpdatePreview_d__24.NativeFieldInfoPtr__pos_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel._OnUpdatePreview_d__24.NativeFieldInfoPtr__pos_5__2)) = value;
				}
			}

			// Token: 0x17002AAA RID: 10922
			// (get) Token: 0x06007E4A RID: 32330 RVA: 0x00240390 File Offset: 0x0023E590
			// (set) Token: 0x06007E4B RID: 32331 RVA: 0x00043F67 File Offset: 0x00042167
			public unsafe float _progress_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel._OnUpdatePreview_d__24.NativeFieldInfoPtr__progress_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameConfigPannel._OnUpdatePreview_d__24.NativeFieldInfoPtr__progress_5__3)) = value;
				}
			}

			// Token: 0x04005302 RID: 21250
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005303 RID: 21251
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005304 RID: 21252
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005305 RID: 21253
			private static readonly IntPtr NativeFieldInfoPtr__pos_5__2;

			// Token: 0x04005306 RID: 21254
			private static readonly IntPtr NativeFieldInfoPtr__progress_5__3;

			// Token: 0x04005307 RID: 21255
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005308 RID: 21256
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005309 RID: 21257
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400530A RID: 21258
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400530B RID: 21259
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400530C RID: 21260
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
