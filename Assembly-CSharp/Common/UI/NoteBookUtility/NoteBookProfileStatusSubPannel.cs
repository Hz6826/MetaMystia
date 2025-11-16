using System;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x020003A1 RID: 929
	public class NoteBookProfileStatusSubPannel : UIPanelExtern
	{
		// Token: 0x0600703D RID: 28733 RVA: 0x002143F8 File Offset: 0x002125F8
		// Note: this type is marked as 'beforefieldinit'.
		static NoteBookProfileStatusSubPannel()
		{
			Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.NoteBookUtility", "NoteBookProfileStatusSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr);
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_basePassion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "basePassion");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_baseTipRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "baseTipRate");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_maxDailyRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "maxDailyRecipes");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_maxDailyBeverages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "maxDailyBeverages");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_dayCookCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "dayCookCount");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "moveSpeed");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_cookSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "cookSpeed");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_qteBuffRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "qteBuffRate");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_qteBuffDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "qteBuffDuration");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_extraCollectRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "extraCollectRate");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_merchantDiscount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "merchantDiscount");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_trayCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "trayCount");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_guestBaseMood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "guestBaseMood");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_guestBasePatience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "guestBasePatience");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_guestSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "guestSpawnRate");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_postiveBuffTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "postiveBuffTime");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_fund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "fund");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "level");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_expValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "expValue");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_nextLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "nextLevel");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_expBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "expBar");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_propertiesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "propertiesParent");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_propertiesField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "propertiesField");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_propertyObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "propertyObject");
			NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_allInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "allInstances");
			NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, 100686203);
			NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, 100686204);
			NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, 100686205);
			NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, 100686206);
			NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, 100686207);
			NoteBookProfileStatusSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, 100686208);
			NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_Method_Internal_Static_String_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, 100686209);
			NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_Method_Internal_Static_String_Single_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, 100686210);
			NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_Method_Private_Void_TextMeshProUGUI_Func_2_LevelProperties_Single_Func_2_Single_String_byref___c__DisplayClass29_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, 100686211);
			NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_Method_Private_Void_Func_2_LevelProperties_Single_String_Func_2_Single_String_Boolean_Boolean_byref___c__DisplayClass29_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, 100686212);
		}

		// Token: 0x17002693 RID: 9875
		// (get) Token: 0x0600703E RID: 28734 RVA: 0x002146E4 File Offset: 0x002128E4
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600703F RID: 28735 RVA: 0x0021472C File Offset: 0x0021292C
		[CallerCount(0)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007040 RID: 28736 RVA: 0x00214774 File Offset: 0x00212974
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExitExtern()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007041 RID: 28737 RVA: 0x002147B0 File Offset: 0x002129B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280223, XrefRangeEnd = 280857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007042 RID: 28738 RVA: 0x002147EC File Offset: 0x002129EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280857, XrefRangeEnd = 280885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007043 RID: 28739 RVA: 0x00214828 File Offset: 0x00212A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280885, XrefRangeEnd = 280894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteBookProfileStatusSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007044 RID: 28740 RVA: 0x00214864 File Offset: 0x00212A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280894, XrefRangeEnd = 280898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_Single_PDM_0(float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_Method_Internal_Static_String_Single_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007045 RID: 28741 RVA: 0x0021489C File Offset: 0x00212A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280898, XrefRangeEnd = 280902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_Single_PDM_1(float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_Method_Internal_Static_String_Single_PDM_1, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007046 RID: 28742 RVA: 0x002148D4 File Offset: 0x00212AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280902, XrefRangeEnd = 280904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_TextMeshProUGUI_Func_2_LevelProperties_Single_Func_2_Single_String_byref___c__DisplayClass29_0_PDM_0(TextMeshProUGUI textMesh, Func<DataBaseCore.LevelProperties, float> getValueCallback, Func<float, string> overrideToStringCallback, ref NoteBookProfileStatusSubPannel.__c__DisplayClass29_0 A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(textMesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getValueCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideToStringCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_4);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_Method_Private_Void_TextMeshProUGUI_Func_2_LevelProperties_Single_Func_2_Single_String_byref___c__DisplayClass29_0_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007047 RID: 28743 RVA: 0x00214950 File Offset: 0x00212B50
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 280938, RefRangeEnd = 280955, XrefRangeStart = 280904, XrefRangeEnd = 280938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Func_2_LevelProperties_Single_String_Func_2_Single_String_Boolean_Boolean_byref___c__DisplayClass29_0_0(Func<DataBaseCore.LevelProperties, float> getValueCallback, string objectTitleKey, Func<float, string> overrideToStringCallback, bool alwaysShow, bool thisProfileInfo, ref NoteBookProfileStatusSubPannel.__c__DisplayClass29_0 A_6)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(getValueCallback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectTitleKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideToStringCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alwaysShow;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref thisProfileInfo;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_6);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.NativeMethodInfoPtr_Method_Private_Void_Func_2_LevelProperties_Single_String_Func_2_Single_String_Boolean_Boolean_byref___c__DisplayClass29_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007048 RID: 28744 RVA: 0x0003CE9A File Offset: 0x0003B09A
		public NoteBookProfileStatusSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700267A RID: 9850
		// (get) Token: 0x06007049 RID: 28745 RVA: 0x002149E8 File Offset: 0x00212BE8
		// (set) Token: 0x0600704A RID: 28746 RVA: 0x0003CEA3 File Offset: 0x0003B0A3
		public unsafe TextMeshProUGUI basePassion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_basePassion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_basePassion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700267B RID: 9851
		// (get) Token: 0x0600704B RID: 28747 RVA: 0x00214A18 File Offset: 0x00212C18
		// (set) Token: 0x0600704C RID: 28748 RVA: 0x0003CEC2 File Offset: 0x0003B0C2
		public unsafe TextMeshProUGUI baseTipRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_baseTipRate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_baseTipRate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700267C RID: 9852
		// (get) Token: 0x0600704D RID: 28749 RVA: 0x00214A48 File Offset: 0x00212C48
		// (set) Token: 0x0600704E RID: 28750 RVA: 0x0003CEE1 File Offset: 0x0003B0E1
		public unsafe TextMeshProUGUI maxDailyRecipes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_maxDailyRecipes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_maxDailyRecipes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700267D RID: 9853
		// (get) Token: 0x0600704F RID: 28751 RVA: 0x00214A78 File Offset: 0x00212C78
		// (set) Token: 0x06007050 RID: 28752 RVA: 0x0003CF00 File Offset: 0x0003B100
		public unsafe TextMeshProUGUI maxDailyBeverages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_maxDailyBeverages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_maxDailyBeverages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700267E RID: 9854
		// (get) Token: 0x06007051 RID: 28753 RVA: 0x00214AA8 File Offset: 0x00212CA8
		// (set) Token: 0x06007052 RID: 28754 RVA: 0x0003CF1F File Offset: 0x0003B11F
		public unsafe TextMeshProUGUI dayCookCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_dayCookCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_dayCookCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700267F RID: 9855
		// (get) Token: 0x06007053 RID: 28755 RVA: 0x00214AD8 File Offset: 0x00212CD8
		// (set) Token: 0x06007054 RID: 28756 RVA: 0x0003CF3E File Offset: 0x0003B13E
		public unsafe TextMeshProUGUI moveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_moveSpeed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_moveSpeed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002680 RID: 9856
		// (get) Token: 0x06007055 RID: 28757 RVA: 0x00214B08 File Offset: 0x00212D08
		// (set) Token: 0x06007056 RID: 28758 RVA: 0x0003CF5D File Offset: 0x0003B15D
		public unsafe TextMeshProUGUI cookSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_cookSpeed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_cookSpeed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002681 RID: 9857
		// (get) Token: 0x06007057 RID: 28759 RVA: 0x00214B38 File Offset: 0x00212D38
		// (set) Token: 0x06007058 RID: 28760 RVA: 0x0003CF7C File Offset: 0x0003B17C
		public unsafe TextMeshProUGUI qteBuffRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_qteBuffRate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_qteBuffRate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002682 RID: 9858
		// (get) Token: 0x06007059 RID: 28761 RVA: 0x00214B68 File Offset: 0x00212D68
		// (set) Token: 0x0600705A RID: 28762 RVA: 0x0003CF9B File Offset: 0x0003B19B
		public unsafe TextMeshProUGUI qteBuffDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_qteBuffDuration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_qteBuffDuration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002683 RID: 9859
		// (get) Token: 0x0600705B RID: 28763 RVA: 0x00214B98 File Offset: 0x00212D98
		// (set) Token: 0x0600705C RID: 28764 RVA: 0x0003CFBA File Offset: 0x0003B1BA
		public unsafe TextMeshProUGUI extraCollectRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_extraCollectRate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_extraCollectRate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002684 RID: 9860
		// (get) Token: 0x0600705D RID: 28765 RVA: 0x00214BC8 File Offset: 0x00212DC8
		// (set) Token: 0x0600705E RID: 28766 RVA: 0x0003CFD9 File Offset: 0x0003B1D9
		public unsafe TextMeshProUGUI merchantDiscount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_merchantDiscount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_merchantDiscount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002685 RID: 9861
		// (get) Token: 0x0600705F RID: 28767 RVA: 0x00214BF8 File Offset: 0x00212DF8
		// (set) Token: 0x06007060 RID: 28768 RVA: 0x0003CFF8 File Offset: 0x0003B1F8
		public unsafe TextMeshProUGUI trayCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_trayCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_trayCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002686 RID: 9862
		// (get) Token: 0x06007061 RID: 28769 RVA: 0x00214C28 File Offset: 0x00212E28
		// (set) Token: 0x06007062 RID: 28770 RVA: 0x0003D017 File Offset: 0x0003B217
		public unsafe TextMeshProUGUI guestBaseMood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_guestBaseMood);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_guestBaseMood), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002687 RID: 9863
		// (get) Token: 0x06007063 RID: 28771 RVA: 0x00214C58 File Offset: 0x00212E58
		// (set) Token: 0x06007064 RID: 28772 RVA: 0x0003D036 File Offset: 0x0003B236
		public unsafe TextMeshProUGUI guestBasePatience
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_guestBasePatience);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_guestBasePatience), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002688 RID: 9864
		// (get) Token: 0x06007065 RID: 28773 RVA: 0x00214C88 File Offset: 0x00212E88
		// (set) Token: 0x06007066 RID: 28774 RVA: 0x0003D055 File Offset: 0x0003B255
		public unsafe TextMeshProUGUI guestSpawnRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_guestSpawnRate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_guestSpawnRate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002689 RID: 9865
		// (get) Token: 0x06007067 RID: 28775 RVA: 0x00214CB8 File Offset: 0x00212EB8
		// (set) Token: 0x06007068 RID: 28776 RVA: 0x0003D074 File Offset: 0x0003B274
		public unsafe TextMeshProUGUI postiveBuffTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_postiveBuffTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_postiveBuffTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700268A RID: 9866
		// (get) Token: 0x06007069 RID: 28777 RVA: 0x00214CE8 File Offset: 0x00212EE8
		// (set) Token: 0x0600706A RID: 28778 RVA: 0x0003D093 File Offset: 0x0003B293
		public unsafe TextMeshProUGUI fund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_fund);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_fund), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700268B RID: 9867
		// (get) Token: 0x0600706B RID: 28779 RVA: 0x00214D18 File Offset: 0x00212F18
		// (set) Token: 0x0600706C RID: 28780 RVA: 0x0003D0B2 File Offset: 0x0003B2B2
		public unsafe TextMeshProUGUI level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_level);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_level), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700268C RID: 9868
		// (get) Token: 0x0600706D RID: 28781 RVA: 0x00214D48 File Offset: 0x00212F48
		// (set) Token: 0x0600706E RID: 28782 RVA: 0x0003D0D1 File Offset: 0x0003B2D1
		public unsafe TextMeshProUGUI expValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_expValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_expValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700268D RID: 9869
		// (get) Token: 0x0600706F RID: 28783 RVA: 0x00214D78 File Offset: 0x00212F78
		// (set) Token: 0x06007070 RID: 28784 RVA: 0x0003D0F0 File Offset: 0x0003B2F0
		public unsafe TextMeshProUGUI nextLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_nextLevel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_nextLevel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700268E RID: 9870
		// (get) Token: 0x06007071 RID: 28785 RVA: 0x00214DA8 File Offset: 0x00212FA8
		// (set) Token: 0x06007072 RID: 28786 RVA: 0x0003D10F File Offset: 0x0003B30F
		public unsafe Image expBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_expBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_expBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700268F RID: 9871
		// (get) Token: 0x06007073 RID: 28787 RVA: 0x00214DD8 File Offset: 0x00212FD8
		// (set) Token: 0x06007074 RID: 28788 RVA: 0x0003D12E File Offset: 0x0003B32E
		public unsafe Transform propertiesParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_propertiesParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_propertiesParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002690 RID: 9872
		// (get) Token: 0x06007075 RID: 28789 RVA: 0x00214E08 File Offset: 0x00213008
		// (set) Token: 0x06007076 RID: 28790 RVA: 0x0003D14D File Offset: 0x0003B34D
		public unsafe Transform propertiesField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_propertiesField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_propertiesField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002691 RID: 9873
		// (get) Token: 0x06007077 RID: 28791 RVA: 0x00214E38 File Offset: 0x00213038
		// (set) Token: 0x06007078 RID: 28792 RVA: 0x0003D16C File Offset: 0x0003B36C
		public unsafe GameObject propertyObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_propertyObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_propertyObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002692 RID: 9874
		// (get) Token: 0x06007079 RID: 28793 RVA: 0x00214E68 File Offset: 0x00213068
		// (set) Token: 0x0600707A RID: 28794 RVA: 0x0003D18B File Offset: 0x0003B38B
		public unsafe HashSet<GameObject> allInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_allInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.NativeFieldInfoPtr_allInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A5C RID: 19036
		private static readonly IntPtr NativeFieldInfoPtr_basePassion;

		// Token: 0x04004A5D RID: 19037
		private static readonly IntPtr NativeFieldInfoPtr_baseTipRate;

		// Token: 0x04004A5E RID: 19038
		private static readonly IntPtr NativeFieldInfoPtr_maxDailyRecipes;

		// Token: 0x04004A5F RID: 19039
		private static readonly IntPtr NativeFieldInfoPtr_maxDailyBeverages;

		// Token: 0x04004A60 RID: 19040
		private static readonly IntPtr NativeFieldInfoPtr_dayCookCount;

		// Token: 0x04004A61 RID: 19041
		private static readonly IntPtr NativeFieldInfoPtr_moveSpeed;

		// Token: 0x04004A62 RID: 19042
		private static readonly IntPtr NativeFieldInfoPtr_cookSpeed;

		// Token: 0x04004A63 RID: 19043
		private static readonly IntPtr NativeFieldInfoPtr_qteBuffRate;

		// Token: 0x04004A64 RID: 19044
		private static readonly IntPtr NativeFieldInfoPtr_qteBuffDuration;

		// Token: 0x04004A65 RID: 19045
		private static readonly IntPtr NativeFieldInfoPtr_extraCollectRate;

		// Token: 0x04004A66 RID: 19046
		private static readonly IntPtr NativeFieldInfoPtr_merchantDiscount;

		// Token: 0x04004A67 RID: 19047
		private static readonly IntPtr NativeFieldInfoPtr_trayCount;

		// Token: 0x04004A68 RID: 19048
		private static readonly IntPtr NativeFieldInfoPtr_guestBaseMood;

		// Token: 0x04004A69 RID: 19049
		private static readonly IntPtr NativeFieldInfoPtr_guestBasePatience;

		// Token: 0x04004A6A RID: 19050
		private static readonly IntPtr NativeFieldInfoPtr_guestSpawnRate;

		// Token: 0x04004A6B RID: 19051
		private static readonly IntPtr NativeFieldInfoPtr_postiveBuffTime;

		// Token: 0x04004A6C RID: 19052
		private static readonly IntPtr NativeFieldInfoPtr_fund;

		// Token: 0x04004A6D RID: 19053
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04004A6E RID: 19054
		private static readonly IntPtr NativeFieldInfoPtr_expValue;

		// Token: 0x04004A6F RID: 19055
		private static readonly IntPtr NativeFieldInfoPtr_nextLevel;

		// Token: 0x04004A70 RID: 19056
		private static readonly IntPtr NativeFieldInfoPtr_expBar;

		// Token: 0x04004A71 RID: 19057
		private static readonly IntPtr NativeFieldInfoPtr_propertiesParent;

		// Token: 0x04004A72 RID: 19058
		private static readonly IntPtr NativeFieldInfoPtr_propertiesField;

		// Token: 0x04004A73 RID: 19059
		private static readonly IntPtr NativeFieldInfoPtr_propertyObject;

		// Token: 0x04004A74 RID: 19060
		private static readonly IntPtr NativeFieldInfoPtr_allInstances;

		// Token: 0x04004A75 RID: 19061
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04004A76 RID: 19062
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x04004A77 RID: 19063
		private static readonly IntPtr NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0;

		// Token: 0x04004A78 RID: 19064
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004A79 RID: 19065
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004A7A RID: 19066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004A7B RID: 19067
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_Single_PDM_0;

		// Token: 0x04004A7C RID: 19068
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_Single_PDM_1;

		// Token: 0x04004A7D RID: 19069
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_TextMeshProUGUI_Func_2_LevelProperties_Single_Func_2_Single_String_byref___c__DisplayClass29_0_PDM_0;

		// Token: 0x04004A7E RID: 19070
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Func_2_LevelProperties_Single_String_Func_2_Single_String_Boolean_Boolean_byref___c__DisplayClass29_0_0;

		// Token: 0x02000EF2 RID: 3826
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookProfileStatusSubPannel+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : ValueType
		{
			// Token: 0x06010CE8 RID: 68840 RVA: 0x003E2D64 File Offset: 0x003E0F64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c__DisplayClass29_0>.NativeClassPtr);
				NoteBookProfileStatusSubPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_levelProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c__DisplayClass29_0>.NativeClassPtr, "levelProfile");
				NoteBookProfileStatusSubPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_nextLevelProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c__DisplayClass29_0>.NativeClassPtr, "nextLevelProfile");
				NoteBookProfileStatusSubPannel.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c__DisplayClass29_0>.NativeClassPtr, "<>4__this");
			}

			// Token: 0x06010CE9 RID: 68841 RVA: 0x000927C6 File Offset: 0x000909C6
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010CEA RID: 68842 RVA: 0x000927CF File Offset: 0x000909CF
			public __c__DisplayClass29_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c__DisplayClass29_0>.NativeClassPtr))
			{
			}

			// Token: 0x17005789 RID: 22409
			// (get) Token: 0x06010CEB RID: 68843 RVA: 0x003E2DCC File Offset: 0x003E0FCC
			// (set) Token: 0x06010CEC RID: 68844 RVA: 0x000927E1 File Offset: 0x000909E1
			public DataBaseCore.LevelProperties levelProfile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_levelProfile);
					return new DataBaseCore.LevelProperties(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_levelProfile), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700578A RID: 22410
			// (get) Token: 0x06010CED RID: 68845 RVA: 0x003E2DFC File Offset: 0x003E0FFC
			// (set) Token: 0x06010CEE RID: 68846 RVA: 0x0009280F File Offset: 0x00090A0F
			public DataBaseCore.LevelProperties nextLevelProfile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_nextLevelProfile);
					return new DataBaseCore.LevelProperties(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_nextLevelProfile), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700578B RID: 22411
			// (get) Token: 0x06010CEF RID: 68847 RVA: 0x003E2E2C File Offset: 0x003E102C
			// (set) Token: 0x06010CF0 RID: 68848 RVA: 0x0009283D File Offset: 0x00090A3D
			public unsafe NoteBookProfileStatusSubPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookProfileStatusSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA13 RID: 43539
			private static readonly IntPtr NativeFieldInfoPtr_levelProfile;

			// Token: 0x0400AA14 RID: 43540
			private static readonly IntPtr NativeFieldInfoPtr_nextLevelProfile;

			// Token: 0x0400AA15 RID: 43541
			private static readonly IntPtr NativeFieldInfoPtr___4__this;
		}

		// Token: 0x02000EF3 RID: 3827
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookProfileStatusSubPannel+<>c__DisplayClass29_1")]
		public sealed class __c__DisplayClass29_1 : Il2CppSystem.Object
		{
			// Token: 0x06010CF1 RID: 68849 RVA: 0x003E2E5C File Offset: 0x003E105C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_1()
			{
				Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c__DisplayClass29_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "<>c__DisplayClass29_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c__DisplayClass29_1>.NativeClassPtr);
				NoteBookProfileStatusSubPannel.__c__DisplayClass29_1.NativeFieldInfoPtr_objectTitleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c__DisplayClass29_1>.NativeClassPtr, "objectTitleKey");
				NoteBookProfileStatusSubPannel.__c__DisplayClass29_1.NativeFieldInfoPtr_displayData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c__DisplayClass29_1>.NativeClassPtr, "displayData");
				NoteBookProfileStatusSubPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c__DisplayClass29_1>.NativeClassPtr, 100686213);
				NoteBookProfileStatusSubPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__OnPanelOpen_b__38_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c__DisplayClass29_1>.NativeClassPtr, 100686214);
				NoteBookProfileStatusSubPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__OnPanelOpen_b__39_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c__DisplayClass29_1>.NativeClassPtr, 100686215);
			}

			// Token: 0x06010CF2 RID: 68850 RVA: 0x003E2EEC File Offset: 0x003E10EC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c__DisplayClass29_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010CF3 RID: 68851 RVA: 0x003E2F28 File Offset: 0x003E1128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280217, XrefRangeEnd = 280219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__38(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__OnPanelOpen_b__38_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010CF4 RID: 68852 RVA: 0x003E2F6C File Offset: 0x003E116C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__39(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__OnPanelOpen_b__39_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010CF5 RID: 68853 RVA: 0x0009285C File Offset: 0x00090A5C
			public __c__DisplayClass29_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700578C RID: 22412
			// (get) Token: 0x06010CF6 RID: 68854 RVA: 0x003E2FB0 File Offset: 0x003E11B0
			// (set) Token: 0x06010CF7 RID: 68855 RVA: 0x00092865 File Offset: 0x00090A65
			public unsafe string objectTitleKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.__c__DisplayClass29_1.NativeFieldInfoPtr_objectTitleKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.__c__DisplayClass29_1.NativeFieldInfoPtr_objectTitleKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700578D RID: 22413
			// (get) Token: 0x06010CF8 RID: 68856 RVA: 0x003E2FD8 File Offset: 0x003E11D8
			// (set) Token: 0x06010CF9 RID: 68857 RVA: 0x00092884 File Offset: 0x00090A84
			public unsafe string displayData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.__c__DisplayClass29_1.NativeFieldInfoPtr_displayData);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookProfileStatusSubPannel.__c__DisplayClass29_1.NativeFieldInfoPtr_displayData), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400AA16 RID: 43542
			private static readonly IntPtr NativeFieldInfoPtr_objectTitleKey;

			// Token: 0x0400AA17 RID: 43543
			private static readonly IntPtr NativeFieldInfoPtr_displayData;

			// Token: 0x0400AA18 RID: 43544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA19 RID: 43545
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__38_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AA1A RID: 43546
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__39_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000EF4 RID: 3828
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookProfileStatusSubPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010CFA RID: 68858 RVA: 0x003E3000 File Offset: 0x003E1200
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr);
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_0");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_4");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_5");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_6");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_7");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_8");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_9");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_10");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_11");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_12");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_13");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_14");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_15");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_16");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_17");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_18");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_19");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_21");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_22");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_23");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_24");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_25");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_26 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_26");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_27 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_27");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_28 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_28");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_29 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_29");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_30");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_31 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_31");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_32");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_33 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_33");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_34 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_34");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_35 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_35");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_36 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_36");
				NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_37 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, "<>9__29_37");
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686217);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686218);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_4_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686219);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_5_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686220);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_6_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686221);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_7_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686222);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_8_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686223);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_9_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686224);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_10_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686225);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_11_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686226);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_12_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686227);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_13_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686228);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_14_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686229);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_15_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686230);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_16_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686231);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_17_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686232);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_18_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686233);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_19_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686234);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_21_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686235);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_22_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686236);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_23_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686237);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_24_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686238);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_25_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686239);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_26_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686240);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_27_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686241);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_28_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686242);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_29_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686243);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_30_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686244);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_31_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686245);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_32_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686246);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_33_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686247);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_34_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686248);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_35_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686249);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_36_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686250);
				NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_37_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr, 100686251);
			}

			// Token: 0x06010CFB RID: 68859 RVA: 0x003E35A4 File Offset: 0x003E17A4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookProfileStatusSubPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010CFC RID: 68860 RVA: 0x003E35E0 File Offset: 0x003E17E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280219, XrefRangeEnd = 280223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__29_0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010CFD RID: 68861 RVA: 0x003E3624 File Offset: 0x003E1824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_4(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_4_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010CFE RID: 68862 RVA: 0x003E3678 File Offset: 0x003E1878
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_5(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_5_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010CFF RID: 68863 RVA: 0x003E36CC File Offset: 0x003E18CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_6(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_6_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D00 RID: 68864 RVA: 0x003E3720 File Offset: 0x003E1920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_7(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_7_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D01 RID: 68865 RVA: 0x003E3774 File Offset: 0x003E1974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_8(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_8_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D02 RID: 68866 RVA: 0x003E37C8 File Offset: 0x003E19C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_9(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_9_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D03 RID: 68867 RVA: 0x003E381C File Offset: 0x003E1A1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_10(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_10_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D04 RID: 68868 RVA: 0x003E3870 File Offset: 0x003E1A70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_11(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_11_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D05 RID: 68869 RVA: 0x003E38C4 File Offset: 0x003E1AC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_12(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_12_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D06 RID: 68870 RVA: 0x003E3918 File Offset: 0x003E1B18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_13(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_13_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D07 RID: 68871 RVA: 0x003E396C File Offset: 0x003E1B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_14(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_14_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D08 RID: 68872 RVA: 0x003E39C0 File Offset: 0x003E1BC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_15(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_15_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D09 RID: 68873 RVA: 0x003E3A14 File Offset: 0x003E1C14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_16(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_16_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D0A RID: 68874 RVA: 0x003E3A68 File Offset: 0x003E1C68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_17(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_17_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D0B RID: 68875 RVA: 0x003E3ABC File Offset: 0x003E1CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_18(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_18_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D0C RID: 68876 RVA: 0x003E3B10 File Offset: 0x003E1D10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_19(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_19_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D0D RID: 68877 RVA: 0x003E3B64 File Offset: 0x003E1D64
			[CallerCount(0)]
			public unsafe float _OnPanelOpen_b__29_21(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_21_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D0E RID: 68878 RVA: 0x003E3BB8 File Offset: 0x003E1DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_22(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_22_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D0F RID: 68879 RVA: 0x003E3C0C File Offset: 0x003E1E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_23(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_23_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D10 RID: 68880 RVA: 0x003E3C60 File Offset: 0x003E1E60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_24(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_24_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D11 RID: 68881 RVA: 0x003E3CB4 File Offset: 0x003E1EB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_25(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_25_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D12 RID: 68882 RVA: 0x003E3D08 File Offset: 0x003E1F08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_26(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_26_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D13 RID: 68883 RVA: 0x003E3D5C File Offset: 0x003E1F5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_27(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_27_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D14 RID: 68884 RVA: 0x003E3DB0 File Offset: 0x003E1FB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_28(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_28_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D15 RID: 68885 RVA: 0x003E3E04 File Offset: 0x003E2004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_29(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_29_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D16 RID: 68886 RVA: 0x003E3E58 File Offset: 0x003E2058
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_30(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_30_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D17 RID: 68887 RVA: 0x003E3EAC File Offset: 0x003E20AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_31(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_31_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D18 RID: 68888 RVA: 0x003E3F00 File Offset: 0x003E2100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_32(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_32_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D19 RID: 68889 RVA: 0x003E3F54 File Offset: 0x003E2154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_33(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_33_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D1A RID: 68890 RVA: 0x003E3FA8 File Offset: 0x003E21A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_34(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_34_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D1B RID: 68891 RVA: 0x003E3FFC File Offset: 0x003E21FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_35(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_35_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D1C RID: 68892 RVA: 0x003E4050 File Offset: 0x003E2250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_36(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_36_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D1D RID: 68893 RVA: 0x003E40A4 File Offset: 0x003E22A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnPanelOpen_b__29_37(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookProfileStatusSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_37_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D1E RID: 68894 RVA: 0x000928A3 File Offset: 0x00090AA3
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700578E RID: 22414
			// (get) Token: 0x06010D1F RID: 68895 RVA: 0x003E40F8 File Offset: 0x003E22F8
			// (set) Token: 0x06010D20 RID: 68896 RVA: 0x000928AC File Offset: 0x00090AAC
			public unsafe static NoteBookProfileStatusSubPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookProfileStatusSubPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700578F RID: 22415
			// (get) Token: 0x06010D21 RID: 68897 RVA: 0x003E4120 File Offset: 0x003E2320
			// (set) Token: 0x06010D22 RID: 68898 RVA: 0x000928BE File Offset: 0x00090ABE
			public unsafe static Action<GameObject> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005790 RID: 22416
			// (get) Token: 0x06010D23 RID: 68899 RVA: 0x003E4148 File Offset: 0x003E2348
			// (set) Token: 0x06010D24 RID: 68900 RVA: 0x000928D0 File Offset: 0x00090AD0
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005791 RID: 22417
			// (get) Token: 0x06010D25 RID: 68901 RVA: 0x003E4170 File Offset: 0x003E2370
			// (set) Token: 0x06010D26 RID: 68902 RVA: 0x000928E2 File Offset: 0x00090AE2
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005792 RID: 22418
			// (get) Token: 0x06010D27 RID: 68903 RVA: 0x003E4198 File Offset: 0x003E2398
			// (set) Token: 0x06010D28 RID: 68904 RVA: 0x000928F4 File Offset: 0x00090AF4
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005793 RID: 22419
			// (get) Token: 0x06010D29 RID: 68905 RVA: 0x003E41C0 File Offset: 0x003E23C0
			// (set) Token: 0x06010D2A RID: 68906 RVA: 0x00092906 File Offset: 0x00090B06
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005794 RID: 22420
			// (get) Token: 0x06010D2B RID: 68907 RVA: 0x003E41E8 File Offset: 0x003E23E8
			// (set) Token: 0x06010D2C RID: 68908 RVA: 0x00092918 File Offset: 0x00090B18
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005795 RID: 22421
			// (get) Token: 0x06010D2D RID: 68909 RVA: 0x003E4210 File Offset: 0x003E2410
			// (set) Token: 0x06010D2E RID: 68910 RVA: 0x0009292A File Offset: 0x00090B2A
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005796 RID: 22422
			// (get) Token: 0x06010D2F RID: 68911 RVA: 0x003E4238 File Offset: 0x003E2438
			// (set) Token: 0x06010D30 RID: 68912 RVA: 0x0009293C File Offset: 0x00090B3C
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005797 RID: 22423
			// (get) Token: 0x06010D31 RID: 68913 RVA: 0x003E4260 File Offset: 0x003E2460
			// (set) Token: 0x06010D32 RID: 68914 RVA: 0x0009294E File Offset: 0x00090B4E
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005798 RID: 22424
			// (get) Token: 0x06010D33 RID: 68915 RVA: 0x003E4288 File Offset: 0x003E2488
			// (set) Token: 0x06010D34 RID: 68916 RVA: 0x00092960 File Offset: 0x00090B60
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005799 RID: 22425
			// (get) Token: 0x06010D35 RID: 68917 RVA: 0x003E42B0 File Offset: 0x003E24B0
			// (set) Token: 0x06010D36 RID: 68918 RVA: 0x00092972 File Offset: 0x00090B72
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700579A RID: 22426
			// (get) Token: 0x06010D37 RID: 68919 RVA: 0x003E42D8 File Offset: 0x003E24D8
			// (set) Token: 0x06010D38 RID: 68920 RVA: 0x00092984 File Offset: 0x00090B84
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700579B RID: 22427
			// (get) Token: 0x06010D39 RID: 68921 RVA: 0x003E4300 File Offset: 0x003E2500
			// (set) Token: 0x06010D3A RID: 68922 RVA: 0x00092996 File Offset: 0x00090B96
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700579C RID: 22428
			// (get) Token: 0x06010D3B RID: 68923 RVA: 0x003E4328 File Offset: 0x003E2528
			// (set) Token: 0x06010D3C RID: 68924 RVA: 0x000929A8 File Offset: 0x00090BA8
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700579D RID: 22429
			// (get) Token: 0x06010D3D RID: 68925 RVA: 0x003E4350 File Offset: 0x003E2550
			// (set) Token: 0x06010D3E RID: 68926 RVA: 0x000929BA File Offset: 0x00090BBA
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_17
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_17, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_17, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700579E RID: 22430
			// (get) Token: 0x06010D3F RID: 68927 RVA: 0x003E4378 File Offset: 0x003E2578
			// (set) Token: 0x06010D40 RID: 68928 RVA: 0x000929CC File Offset: 0x00090BCC
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_18
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_18, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_18, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700579F RID: 22431
			// (get) Token: 0x06010D41 RID: 68929 RVA: 0x003E43A0 File Offset: 0x003E25A0
			// (set) Token: 0x06010D42 RID: 68930 RVA: 0x000929DE File Offset: 0x00090BDE
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057A0 RID: 22432
			// (get) Token: 0x06010D43 RID: 68931 RVA: 0x003E43C8 File Offset: 0x003E25C8
			// (set) Token: 0x06010D44 RID: 68932 RVA: 0x000929F0 File Offset: 0x00090BF0
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_21
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_21, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_21, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057A1 RID: 22433
			// (get) Token: 0x06010D45 RID: 68933 RVA: 0x003E43F0 File Offset: 0x003E25F0
			// (set) Token: 0x06010D46 RID: 68934 RVA: 0x00092A02 File Offset: 0x00090C02
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_22
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_22, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_22, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057A2 RID: 22434
			// (get) Token: 0x06010D47 RID: 68935 RVA: 0x003E4418 File Offset: 0x003E2618
			// (set) Token: 0x06010D48 RID: 68936 RVA: 0x00092A14 File Offset: 0x00090C14
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_23
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_23, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_23, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057A3 RID: 22435
			// (get) Token: 0x06010D49 RID: 68937 RVA: 0x003E4440 File Offset: 0x003E2640
			// (set) Token: 0x06010D4A RID: 68938 RVA: 0x00092A26 File Offset: 0x00090C26
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_24
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_24, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_24, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057A4 RID: 22436
			// (get) Token: 0x06010D4B RID: 68939 RVA: 0x003E4468 File Offset: 0x003E2668
			// (set) Token: 0x06010D4C RID: 68940 RVA: 0x00092A38 File Offset: 0x00090C38
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_25
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_25, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_25, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057A5 RID: 22437
			// (get) Token: 0x06010D4D RID: 68941 RVA: 0x003E4490 File Offset: 0x003E2690
			// (set) Token: 0x06010D4E RID: 68942 RVA: 0x00092A4A File Offset: 0x00090C4A
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_26
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_26, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_26, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057A6 RID: 22438
			// (get) Token: 0x06010D4F RID: 68943 RVA: 0x003E44B8 File Offset: 0x003E26B8
			// (set) Token: 0x06010D50 RID: 68944 RVA: 0x00092A5C File Offset: 0x00090C5C
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_27
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_27, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_27, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057A7 RID: 22439
			// (get) Token: 0x06010D51 RID: 68945 RVA: 0x003E44E0 File Offset: 0x003E26E0
			// (set) Token: 0x06010D52 RID: 68946 RVA: 0x00092A6E File Offset: 0x00090C6E
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_28
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_28, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_28, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057A8 RID: 22440
			// (get) Token: 0x06010D53 RID: 68947 RVA: 0x003E4508 File Offset: 0x003E2708
			// (set) Token: 0x06010D54 RID: 68948 RVA: 0x00092A80 File Offset: 0x00090C80
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_29
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_29, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_29, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057A9 RID: 22441
			// (get) Token: 0x06010D55 RID: 68949 RVA: 0x003E4530 File Offset: 0x003E2730
			// (set) Token: 0x06010D56 RID: 68950 RVA: 0x00092A92 File Offset: 0x00090C92
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_30
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_30, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_30, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057AA RID: 22442
			// (get) Token: 0x06010D57 RID: 68951 RVA: 0x003E4558 File Offset: 0x003E2758
			// (set) Token: 0x06010D58 RID: 68952 RVA: 0x00092AA4 File Offset: 0x00090CA4
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_31
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_31, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_31, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057AB RID: 22443
			// (get) Token: 0x06010D59 RID: 68953 RVA: 0x003E4580 File Offset: 0x003E2780
			// (set) Token: 0x06010D5A RID: 68954 RVA: 0x00092AB6 File Offset: 0x00090CB6
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_32
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_32, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_32, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057AC RID: 22444
			// (get) Token: 0x06010D5B RID: 68955 RVA: 0x003E45A8 File Offset: 0x003E27A8
			// (set) Token: 0x06010D5C RID: 68956 RVA: 0x00092AC8 File Offset: 0x00090CC8
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_33
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_33, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_33, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057AD RID: 22445
			// (get) Token: 0x06010D5D RID: 68957 RVA: 0x003E45D0 File Offset: 0x003E27D0
			// (set) Token: 0x06010D5E RID: 68958 RVA: 0x00092ADA File Offset: 0x00090CDA
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_34
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_34, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_34, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057AE RID: 22446
			// (get) Token: 0x06010D5F RID: 68959 RVA: 0x003E45F8 File Offset: 0x003E27F8
			// (set) Token: 0x06010D60 RID: 68960 RVA: 0x00092AEC File Offset: 0x00090CEC
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_35
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_35, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_35, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057AF RID: 22447
			// (get) Token: 0x06010D61 RID: 68961 RVA: 0x003E4620 File Offset: 0x003E2820
			// (set) Token: 0x06010D62 RID: 68962 RVA: 0x00092AFE File Offset: 0x00090CFE
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_36
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_36, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_36, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057B0 RID: 22448
			// (get) Token: 0x06010D63 RID: 68963 RVA: 0x003E4648 File Offset: 0x003E2848
			// (set) Token: 0x06010D64 RID: 68964 RVA: 0x00092B10 File Offset: 0x00090D10
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__29_37
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_37, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookProfileStatusSubPannel.__c.NativeFieldInfoPtr___9__29_37, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA1B RID: 43547
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AA1C RID: 43548
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x0400AA1D RID: 43549
			private static readonly IntPtr NativeFieldInfoPtr___9__29_4;

			// Token: 0x0400AA1E RID: 43550
			private static readonly IntPtr NativeFieldInfoPtr___9__29_5;

			// Token: 0x0400AA1F RID: 43551
			private static readonly IntPtr NativeFieldInfoPtr___9__29_6;

			// Token: 0x0400AA20 RID: 43552
			private static readonly IntPtr NativeFieldInfoPtr___9__29_7;

			// Token: 0x0400AA21 RID: 43553
			private static readonly IntPtr NativeFieldInfoPtr___9__29_8;

			// Token: 0x0400AA22 RID: 43554
			private static readonly IntPtr NativeFieldInfoPtr___9__29_9;

			// Token: 0x0400AA23 RID: 43555
			private static readonly IntPtr NativeFieldInfoPtr___9__29_10;

			// Token: 0x0400AA24 RID: 43556
			private static readonly IntPtr NativeFieldInfoPtr___9__29_11;

			// Token: 0x0400AA25 RID: 43557
			private static readonly IntPtr NativeFieldInfoPtr___9__29_12;

			// Token: 0x0400AA26 RID: 43558
			private static readonly IntPtr NativeFieldInfoPtr___9__29_13;

			// Token: 0x0400AA27 RID: 43559
			private static readonly IntPtr NativeFieldInfoPtr___9__29_14;

			// Token: 0x0400AA28 RID: 43560
			private static readonly IntPtr NativeFieldInfoPtr___9__29_15;

			// Token: 0x0400AA29 RID: 43561
			private static readonly IntPtr NativeFieldInfoPtr___9__29_16;

			// Token: 0x0400AA2A RID: 43562
			private static readonly IntPtr NativeFieldInfoPtr___9__29_17;

			// Token: 0x0400AA2B RID: 43563
			private static readonly IntPtr NativeFieldInfoPtr___9__29_18;

			// Token: 0x0400AA2C RID: 43564
			private static readonly IntPtr NativeFieldInfoPtr___9__29_19;

			// Token: 0x0400AA2D RID: 43565
			private static readonly IntPtr NativeFieldInfoPtr___9__29_21;

			// Token: 0x0400AA2E RID: 43566
			private static readonly IntPtr NativeFieldInfoPtr___9__29_22;

			// Token: 0x0400AA2F RID: 43567
			private static readonly IntPtr NativeFieldInfoPtr___9__29_23;

			// Token: 0x0400AA30 RID: 43568
			private static readonly IntPtr NativeFieldInfoPtr___9__29_24;

			// Token: 0x0400AA31 RID: 43569
			private static readonly IntPtr NativeFieldInfoPtr___9__29_25;

			// Token: 0x0400AA32 RID: 43570
			private static readonly IntPtr NativeFieldInfoPtr___9__29_26;

			// Token: 0x0400AA33 RID: 43571
			private static readonly IntPtr NativeFieldInfoPtr___9__29_27;

			// Token: 0x0400AA34 RID: 43572
			private static readonly IntPtr NativeFieldInfoPtr___9__29_28;

			// Token: 0x0400AA35 RID: 43573
			private static readonly IntPtr NativeFieldInfoPtr___9__29_29;

			// Token: 0x0400AA36 RID: 43574
			private static readonly IntPtr NativeFieldInfoPtr___9__29_30;

			// Token: 0x0400AA37 RID: 43575
			private static readonly IntPtr NativeFieldInfoPtr___9__29_31;

			// Token: 0x0400AA38 RID: 43576
			private static readonly IntPtr NativeFieldInfoPtr___9__29_32;

			// Token: 0x0400AA39 RID: 43577
			private static readonly IntPtr NativeFieldInfoPtr___9__29_33;

			// Token: 0x0400AA3A RID: 43578
			private static readonly IntPtr NativeFieldInfoPtr___9__29_34;

			// Token: 0x0400AA3B RID: 43579
			private static readonly IntPtr NativeFieldInfoPtr___9__29_35;

			// Token: 0x0400AA3C RID: 43580
			private static readonly IntPtr NativeFieldInfoPtr___9__29_36;

			// Token: 0x0400AA3D RID: 43581
			private static readonly IntPtr NativeFieldInfoPtr___9__29_37;

			// Token: 0x0400AA3E RID: 43582
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA3F RID: 43583
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_0_Internal_Void_GameObject_0;

			// Token: 0x0400AA40 RID: 43584
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_4_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA41 RID: 43585
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_5_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA42 RID: 43586
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_6_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA43 RID: 43587
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_7_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA44 RID: 43588
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_8_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA45 RID: 43589
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_9_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA46 RID: 43590
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_10_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA47 RID: 43591
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_11_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA48 RID: 43592
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_12_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA49 RID: 43593
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_13_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA4A RID: 43594
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_14_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA4B RID: 43595
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_15_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA4C RID: 43596
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_16_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA4D RID: 43597
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_17_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA4E RID: 43598
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_18_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA4F RID: 43599
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_19_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA50 RID: 43600
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_21_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA51 RID: 43601
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_22_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA52 RID: 43602
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_23_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA53 RID: 43603
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_24_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA54 RID: 43604
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_25_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA55 RID: 43605
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_26_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA56 RID: 43606
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_27_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA57 RID: 43607
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_28_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA58 RID: 43608
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_29_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA59 RID: 43609
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_30_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA5A RID: 43610
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_31_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA5B RID: 43611
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_32_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA5C RID: 43612
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_33_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA5D RID: 43613
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_34_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA5E RID: 43614
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_35_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA5F RID: 43615
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_36_Internal_Single_LevelProperties_0;

			// Token: 0x0400AA60 RID: 43616
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_37_Internal_Single_LevelProperties_0;
		}
	}
}
