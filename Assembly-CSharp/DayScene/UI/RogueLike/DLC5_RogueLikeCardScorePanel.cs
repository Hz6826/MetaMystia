using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000FC RID: 252
	public class DLC5_RogueLikeCardScorePanel : UIPanelParamOpen<List<DLC5_RogueLikeCardScorePanel.CardScorePair>>
	{
		// Token: 0x06001B96 RID: 7062 RVA: 0x000FB268 File Offset: 0x000F9468
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardScorePanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardScorePanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr);
			DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ContinueButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr, "m_ContinueButton");
			DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ScoreValueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr, "m_ScoreValueText");
			DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ScoreTypeSucceedElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr, "m_ScoreTypeSucceedElement");
			DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ScoreTypeSucceedParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr, "m_ScoreTypeSucceedParent");
			DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ScoreTypeFailedElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr, "m_ScoreTypeFailedElement");
			DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ScoreTypeFailedParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr, "m_ScoreTypeFailedParent");
			DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_SucceedInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr, "m_SucceedInstance");
			DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_FailedInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr, "m_FailedInstance");
			DLC5_RogueLikeCardScorePanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr, 100668301);
			DLC5_RogueLikeCardScorePanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_List_1_CardScorePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr, 100668302);
			DLC5_RogueLikeCardScorePanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr, 100668303);
			DLC5_RogueLikeCardScorePanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr, 100668304);
			DLC5_RogueLikeCardScorePanel.NativeMethodInfoPtr_Method_Internal_Static_Void_UIElementCluster_ValueTuple_2_CardScorePair_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr, 100668305);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x000FB39C File Offset: 0x000F959C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72658, XrefRangeEnd = 72670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardScorePanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x000FB3D8 File Offset: 0x000F95D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72670, XrefRangeEnd = 72776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(List<DLC5_RogueLikeCardScorePanel.CardScorePair> openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(openParam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardScorePanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_List_1_CardScorePair_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x000FB428 File Offset: 0x000F9628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72776, XrefRangeEnd = 72788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardScorePanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x000FB464 File Offset: 0x000F9664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72788, XrefRangeEnd = 72804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardScorePanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardScorePanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x000FB4A0 File Offset: 0x000F96A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72804, XrefRangeEnd = 72830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_UIElementCluster_ValueTuple_2_CardScorePair_Boolean_PDM_0(UIElementCluster cluster, ValueTuple<DLC5_RogueLikeCardScorePanel.CardScorePair, bool> cardScorePairProperty)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cardScorePairProperty));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardScorePanel.NativeMethodInfoPtr_Method_Internal_Static_Void_UIElementCluster_ValueTuple_2_CardScorePair_Boolean_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x00010C8E File Offset: 0x0000EE8E
		public DLC5_RogueLikeCardScorePanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x000FB4F0 File Offset: 0x000F96F0
		// (set) Token: 0x06001B9E RID: 7070 RVA: 0x00010C97 File Offset: 0x0000EE97
		public unsafe UIButtonSimple m_ContinueButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ContinueButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ContinueButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x000FB520 File Offset: 0x000F9720
		// (set) Token: 0x06001BA0 RID: 7072 RVA: 0x00010CB6 File Offset: 0x0000EEB6
		public unsafe TextMeshProUGUI m_ScoreValueText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ScoreValueText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ScoreValueText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x000FB550 File Offset: 0x000F9750
		// (set) Token: 0x06001BA2 RID: 7074 RVA: 0x00010CD5 File Offset: 0x0000EED5
		public unsafe GameObject m_ScoreTypeSucceedElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ScoreTypeSucceedElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ScoreTypeSucceedElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x000FB580 File Offset: 0x000F9780
		// (set) Token: 0x06001BA4 RID: 7076 RVA: 0x00010CF4 File Offset: 0x0000EEF4
		public unsafe RectTransform m_ScoreTypeSucceedParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ScoreTypeSucceedParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ScoreTypeSucceedParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x000FB5B0 File Offset: 0x000F97B0
		// (set) Token: 0x06001BA6 RID: 7078 RVA: 0x00010D13 File Offset: 0x0000EF13
		public unsafe GameObject m_ScoreTypeFailedElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ScoreTypeFailedElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ScoreTypeFailedElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x000FB5E0 File Offset: 0x000F97E0
		// (set) Token: 0x06001BA8 RID: 7080 RVA: 0x00010D32 File Offset: 0x0000EF32
		public unsafe RectTransform m_ScoreTypeFailedParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ScoreTypeFailedParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_ScoreTypeFailedParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001BA9 RID: 7081 RVA: 0x000FB610 File Offset: 0x000F9810
		// (set) Token: 0x06001BAA RID: 7082 RVA: 0x00010D51 File Offset: 0x0000EF51
		public unsafe List<GameObject> m_SucceedInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_SucceedInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_SucceedInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001BAB RID: 7083 RVA: 0x000FB640 File Offset: 0x000F9840
		// (set) Token: 0x06001BAC RID: 7084 RVA: 0x00010D70 File Offset: 0x0000EF70
		public unsafe List<GameObject> m_FailedInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_FailedInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.NativeFieldInfoPtr_m_FailedInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeFieldInfoPtr_m_ContinueButton;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeFieldInfoPtr_m_ScoreValueText;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeFieldInfoPtr_m_ScoreTypeSucceedElement;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeFieldInfoPtr_m_ScoreTypeSucceedParent;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeFieldInfoPtr_m_ScoreTypeFailedElement;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeFieldInfoPtr_m_ScoreTypeFailedParent;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeFieldInfoPtr_m_SucceedInstance;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeFieldInfoPtr_m_FailedInstance;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_List_1_CardScorePair_0;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_UIElementCluster_ValueTuple_2_CardScorePair_Boolean_PDM_0;

		// Token: 0x020006C3 RID: 1731
		public sealed class CardScorePair : ValueType
		{
			// Token: 0x06009950 RID: 39248 RVA: 0x0028E5D8 File Offset: 0x0028C7D8
			// Note: this type is marked as 'beforefieldinit'.
			static CardScorePair()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.CardScorePair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr, "CardScorePair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.CardScorePair>.NativeClassPtr);
				DLC5_RogueLikeCardScorePanel.CardScorePair.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.CardScorePair>.NativeClassPtr, "Label");
				DLC5_RogueLikeCardScorePanel.CardScorePair.NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.CardScorePair>.NativeClassPtr, "Score");
				DLC5_RogueLikeCardScorePanel.CardScorePair.NativeFieldInfoPtr_Succeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.CardScorePair>.NativeClassPtr, "Succeed");
				DLC5_RogueLikeCardScorePanel.CardScorePair.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.CardScorePair>.NativeClassPtr, 100668306);
			}

			// Token: 0x06009951 RID: 39249 RVA: 0x0028E654 File Offset: 0x0028C854
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 72642, RefRangeEnd = 72648, XrefRangeStart = 72641, XrefRangeEnd = 72642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CardScorePair(string label, int score, bool succeed) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.CardScorePair>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref succeed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardScorePanel.CardScorePair.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009952 RID: 39250 RVA: 0x00052F06 File Offset: 0x00051106
			public CardScorePair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009953 RID: 39251 RVA: 0x00052F0F File Offset: 0x0005110F
			public CardScorePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.CardScorePair>.NativeClassPtr))
			{
			}

			// Token: 0x170032E4 RID: 13028
			// (get) Token: 0x06009954 RID: 39252 RVA: 0x0028E6C0 File Offset: 0x0028C8C0
			// (set) Token: 0x06009955 RID: 39253 RVA: 0x00052F21 File Offset: 0x00051121
			public unsafe string Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.CardScorePair.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.CardScorePair.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170032E5 RID: 13029
			// (get) Token: 0x06009956 RID: 39254 RVA: 0x0028E6E8 File Offset: 0x0028C8E8
			// (set) Token: 0x06009957 RID: 39255 RVA: 0x00052F40 File Offset: 0x00051140
			public unsafe int Score
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.CardScorePair.NativeFieldInfoPtr_Score);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.CardScorePair.NativeFieldInfoPtr_Score)) = value;
				}
			}

			// Token: 0x170032E6 RID: 13030
			// (get) Token: 0x06009958 RID: 39256 RVA: 0x0028E710 File Offset: 0x0028C910
			// (set) Token: 0x06009959 RID: 39257 RVA: 0x00052F5B File Offset: 0x0005115B
			public unsafe bool Succeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.CardScorePair.NativeFieldInfoPtr_Succeed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.CardScorePair.NativeFieldInfoPtr_Succeed)) = value;
				}
			}

			// Token: 0x0400633E RID: 25406
			private static readonly IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x0400633F RID: 25407
			private static readonly IntPtr NativeFieldInfoPtr_Score;

			// Token: 0x04006340 RID: 25408
			private static readonly IntPtr NativeFieldInfoPtr_Succeed;

			// Token: 0x04006341 RID: 25409
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Boolean_0;
		}

		// Token: 0x020006C4 RID: 1732
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardScorePanel+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600995A RID: 39258 RVA: 0x0028E738 File Offset: 0x0028C938
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0>.NativeClassPtr);
				DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0.NativeFieldInfoPtr_cardScorePair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0>.NativeClassPtr, "cardScorePair");
				DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0.NativeFieldInfoPtr_isNotLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0>.NativeClassPtr, "isNotLast");
				DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0>.NativeClassPtr, 100668307);
				DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0>.NativeClassPtr, 100668308);
				DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0>.NativeClassPtr, 100668309);
				DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0>.NativeClassPtr, 100668310);
			}

			// Token: 0x0600995B RID: 39259 RVA: 0x0028E7DC File Offset: 0x0028C9DC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600995C RID: 39260 RVA: 0x0028E818 File Offset: 0x0028CA18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72648, XrefRangeEnd = 72650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__3(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600995D RID: 39261 RVA: 0x0028E85C File Offset: 0x0028CA5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72650, XrefRangeEnd = 72656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600995E RID: 39262 RVA: 0x0028E8A0 File Offset: 0x0028CAA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72656, XrefRangeEnd = 72658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__5(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600995F RID: 39263 RVA: 0x00052F76 File Offset: 0x00051176
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032E7 RID: 13031
			// (get) Token: 0x06009960 RID: 39264 RVA: 0x0028E8E4 File Offset: 0x0028CAE4
			// (set) Token: 0x06009961 RID: 39265 RVA: 0x00052F7F File Offset: 0x0005117F
			public DLC5_RogueLikeCardScorePanel.CardScorePair cardScorePair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0.NativeFieldInfoPtr_cardScorePair);
					return new DLC5_RogueLikeCardScorePanel.CardScorePair(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.CardScorePair>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0.NativeFieldInfoPtr_cardScorePair), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.CardScorePair>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170032E8 RID: 13032
			// (get) Token: 0x06009962 RID: 39266 RVA: 0x0028E914 File Offset: 0x0028CB14
			// (set) Token: 0x06009963 RID: 39267 RVA: 0x00052FAD File Offset: 0x000511AD
			public unsafe bool isNotLast
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0.NativeFieldInfoPtr_isNotLast);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardScorePanel.__c__DisplayClass10_0.NativeFieldInfoPtr_isNotLast)) = value;
				}
			}

			// Token: 0x04006342 RID: 25410
			private static readonly IntPtr NativeFieldInfoPtr_cardScorePair;

			// Token: 0x04006343 RID: 25411
			private static readonly IntPtr NativeFieldInfoPtr_isNotLast;

			// Token: 0x04006344 RID: 25412
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006345 RID: 25413
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006346 RID: 25414
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006347 RID: 25415
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Void_Image_0;
		}

		// Token: 0x020006C5 RID: 1733
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardScorePanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009964 RID: 39268 RVA: 0x0028E93C File Offset: 0x0028CB3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c>.NativeClassPtr);
				DLC5_RogueLikeCardScorePanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeCardScorePanel.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c>.NativeClassPtr, "<>9__10_0");
				DLC5_RogueLikeCardScorePanel.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c>.NativeClassPtr, "<>9__10_1");
				DLC5_RogueLikeCardScorePanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c>.NativeClassPtr, 100668312);
				DLC5_RogueLikeCardScorePanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__10_0_Internal_Boolean_CardScorePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c>.NativeClassPtr, 100668313);
				DLC5_RogueLikeCardScorePanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__10_1_Internal_Int32_CardScorePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c>.NativeClassPtr, 100668314);
			}

			// Token: 0x06009965 RID: 39269 RVA: 0x0028E9E0 File Offset: 0x0028CBE0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardScorePanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardScorePanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009966 RID: 39270 RVA: 0x0028EA1C File Offset: 0x0028CC1C
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__10_0(DLC5_RogueLikeCardScorePanel.CardScorePair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardScorePanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__10_0_Internal_Boolean_CardScorePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009967 RID: 39271 RVA: 0x0028EA70 File Offset: 0x0028CC70
			[CallerCount(0)]
			public unsafe int _OnPanelOpen_b__10_1(DLC5_RogueLikeCardScorePanel.CardScorePair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardScorePanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__10_1_Internal_Int32_CardScorePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009968 RID: 39272 RVA: 0x00052FC8 File Offset: 0x000511C8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032E9 RID: 13033
			// (get) Token: 0x06009969 RID: 39273 RVA: 0x0028EAC4 File Offset: 0x0028CCC4
			// (set) Token: 0x0600996A RID: 39274 RVA: 0x00052FD1 File Offset: 0x000511D1
			public unsafe static DLC5_RogueLikeCardScorePanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardScorePanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardScorePanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardScorePanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032EA RID: 13034
			// (get) Token: 0x0600996B RID: 39275 RVA: 0x0028EAEC File Offset: 0x0028CCEC
			// (set) Token: 0x0600996C RID: 39276 RVA: 0x00052FE3 File Offset: 0x000511E3
			public unsafe static Func<DLC5_RogueLikeCardScorePanel.CardScorePair, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardScorePanel.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeCardScorePanel.CardScorePair, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardScorePanel.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032EB RID: 13035
			// (get) Token: 0x0600996D RID: 39277 RVA: 0x0028EB14 File Offset: 0x0028CD14
			// (set) Token: 0x0600996E RID: 39278 RVA: 0x00052FF5 File Offset: 0x000511F5
			public unsafe static Func<DLC5_RogueLikeCardScorePanel.CardScorePair, int> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardScorePanel.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeCardScorePanel.CardScorePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardScorePanel.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006348 RID: 25416
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006349 RID: 25417
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x0400634A RID: 25418
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x0400634B RID: 25419
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400634C RID: 25420
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__10_0_Internal_Boolean_CardScorePair_0;

			// Token: 0x0400634D RID: 25421
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__10_1_Internal_Int32_CardScorePair_0;
		}
	}
}
