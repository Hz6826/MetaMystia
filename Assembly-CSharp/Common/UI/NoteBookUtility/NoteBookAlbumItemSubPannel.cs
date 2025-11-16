using System;
using Common.UI.Filter;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Plugins.DEYU;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x0200039A RID: 922
	public class NoteBookAlbumItemSubPannel : UISubPanel<NoteBookAlbumPannel>
	{
		// Token: 0x06006EA5 RID: 28325 RVA: 0x0020F2BC File Offset: 0x0020D4BC
		// Note: this type is marked as 'beforefieldinit'.
		static NoteBookAlbumItemSubPannel()
		{
			Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.NoteBookUtility", "NoteBookAlbumItemSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr);
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_ActionExecutionScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_ActionExecutionScheduler");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_ItemParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "ItemParent");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_ItemDescriber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "ItemDescriber");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_Scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "Scroller");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_DescriberPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "DescriberPannel");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_NullPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "NullPannel");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_FilterBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "FilterBtn");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_FoodField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "FoodField");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_BevField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "BevField");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_IngField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "IngField");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_CookerField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "CookerField");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_ItemField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "ItemField");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_priceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "priceText");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_Bevs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_Bevs");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_BevsFilterQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_BevsFilterQueue");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_Cookers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_Cookers");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_CookersFilterQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_CookersFilterQueue");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_Foods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_Foods");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_FoodsFilterQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_FoodsFilterQueue");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_Ings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_Ings");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_IngsFilterQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_IngsFilterQueue");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_Items");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_ItemsFilterQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_ItemsFilterQueue");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_describeDataCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "describeDataCallback");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_BeverageGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_BeverageGroup");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_BevFieldCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_BevFieldCanvasGroup");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_CookerFieldCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_CookerFieldCanvasGroup");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_ExitCurrentGroupCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_ExitCurrentGroupCallback");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_FoodFieldCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_FoodFieldCanvasGroup");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_FoodGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_FoodGroup");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_IngFieldCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_IngFieldCanvasGroup");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_IngredientGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_IngredientGroup");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_ItemFieldCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_ItemFieldCanvasGroup");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_ItemGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_ItemGroup");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_KitchenwareGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_KitchenwareGroup");
			NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_UpdateObjectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "m_UpdateObjectCallback");
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685931);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685932);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685933);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_ResetFilter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685934);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685935);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685936);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685937);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_SetParamValue_Private_Void_Action_1_NonTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685938);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_T_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685939);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_OnElementSelected_Private_Void_T_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685940);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685941);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685942);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__38_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685943);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_Method_Private_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685944);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685945);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685946);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_10_Private_Void_NonTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685947);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685948);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685949);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_11_Private_Void_NonTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685950);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685951);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685952);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_12_Private_Void_NonTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685953);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_6_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685954);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_7_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685955);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_14_Private_Void_NonTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685956);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_8_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685957);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_9_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685958);
			NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_15_Private_Void_NonTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, 100685959);
		}

		// Token: 0x1700260C RID: 9740
		// (get) Token: 0x06006EA6 RID: 28326 RVA: 0x0020F800 File Offset: 0x0020DA00
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006EA7 RID: 28327 RVA: 0x0020F848 File Offset: 0x0020DA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277123, XrefRangeEnd = 277171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EA8 RID: 28328 RVA: 0x0020F884 File Offset: 0x0020DA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277171, XrefRangeEnd = 277183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EA9 RID: 28329 RVA: 0x0020F8C0 File Offset: 0x0020DAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277183, XrefRangeEnd = 277189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_ResetFilter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EAA RID: 28330 RVA: 0x0020F8F4 File Offset: 0x0020DAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277189, XrefRangeEnd = 277191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EAB RID: 28331 RVA: 0x0020F930 File Offset: 0x0020DB30
		[CallerCount(0)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006EAC RID: 28332 RVA: 0x0020F978 File Offset: 0x0020DB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277191, XrefRangeEnd = 277305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EAD RID: 28333 RVA: 0x0020F9B4 File Offset: 0x0020DBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParamValue(Action<NonTradableObjectBase> describeDataCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(describeDataCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_SetParamValue_Private_Void_Action_1_NonTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EAE RID: 28334 RVA: 0x0020F9F8 File Offset: 0x0020DBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277305, XrefRangeEnd = 277315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementEnabled<T>(T objectBase, UIElementCluster cluster, UIButtonSimple button) where T : NonTradableObjectBase
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = objectBase;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref objectBase;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.MethodInfoStoreGeneric_OnElementEnabled_Private_Void_T_UIElementCluster_UIButtonSimple_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06006EAF RID: 28335 RVA: 0x0020FA94 File Offset: 0x0020DC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277315, XrefRangeEnd = 277326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementSelected<T>(T objectBase, UIElementCluster cluster, UIButtonSimple button) where T : NonTradableObjectBase
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = objectBase;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref objectBase;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.MethodInfoStoreGeneric_OnElementSelected_Private_Void_T_UIElementCluster_UIButtonSimple_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06006EB0 RID: 28336 RVA: 0x0020FB30 File Offset: 0x0020DD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277326, XrefRangeEnd = 277378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EB1 RID: 28337 RVA: 0x0020FB6C File Offset: 0x0020DD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277378, XrefRangeEnd = 277442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteBookAlbumItemSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EB2 RID: 28338 RVA: 0x0020FBA8 File Offset: 0x0020DDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277442, XrefRangeEnd = 277450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__38_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__38_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EB3 RID: 28339 RVA: 0x0020FBDC File Offset: 0x0020DDDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277467, RefRangeEnd = 277468, XrefRangeStart = 277450, XrefRangeEnd = 277467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask Method_Private_UniTask_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_Method_Private_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06006EB4 RID: 28340 RVA: 0x0020FC14 File Offset: 0x0020DE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277468, XrefRangeEnd = 277487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__43_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EB5 RID: 28341 RVA: 0x0020FC48 File Offset: 0x0020DE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277487, XrefRangeEnd = 277529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__43_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EB6 RID: 28342 RVA: 0x0020FC7C File Offset: 0x0020DE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277529, XrefRangeEnd = 277534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__43_10(NonTradableObjectBase x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_10_Private_Void_NonTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EB7 RID: 28343 RVA: 0x0020FCC0 File Offset: 0x0020DEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277534, XrefRangeEnd = 277553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__43_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EB8 RID: 28344 RVA: 0x0020FCF4 File Offset: 0x0020DEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277553, XrefRangeEnd = 277595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__43_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EB9 RID: 28345 RVA: 0x0020FD28 File Offset: 0x0020DF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277595, XrefRangeEnd = 277600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__43_11(NonTradableObjectBase x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_11_Private_Void_NonTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EBA RID: 28346 RVA: 0x0020FD6C File Offset: 0x0020DF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277600, XrefRangeEnd = 277619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__43_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EBB RID: 28347 RVA: 0x0020FDA0 File Offset: 0x0020DFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277619, XrefRangeEnd = 277661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__43_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EBC RID: 28348 RVA: 0x0020FDD4 File Offset: 0x0020DFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277661, XrefRangeEnd = 277666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__43_12(NonTradableObjectBase x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_12_Private_Void_NonTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EBD RID: 28349 RVA: 0x0020FE18 File Offset: 0x0020E018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277666, XrefRangeEnd = 277703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__43_6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_6_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EBE RID: 28350 RVA: 0x0020FE4C File Offset: 0x0020E04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277703, XrefRangeEnd = 277745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__43_7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_7_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EBF RID: 28351 RVA: 0x0020FE80 File Offset: 0x0020E080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277745, XrefRangeEnd = 277748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__43_14(NonTradableObjectBase x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_14_Private_Void_NonTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EC0 RID: 28352 RVA: 0x0020FEC4 File Offset: 0x0020E0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277748, XrefRangeEnd = 277767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__43_8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_8_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EC1 RID: 28353 RVA: 0x0020FEF8 File Offset: 0x0020E0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277767, XrefRangeEnd = 277809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__43_9()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_9_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EC2 RID: 28354 RVA: 0x0020FF2C File Offset: 0x0020E12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__43_15(NonTradableObjectBase x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr__OnPanelOpen_b__43_15_Private_Void_NonTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EC3 RID: 28355 RVA: 0x0003BEF7 File Offset: 0x0003A0F7
		public NoteBookAlbumItemSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025E8 RID: 9704
		// (get) Token: 0x06006EC4 RID: 28356 RVA: 0x0020FF70 File Offset: 0x0020E170
		// (set) Token: 0x06006EC5 RID: 28357 RVA: 0x0003BF00 File Offset: 0x0003A100
		public unsafe ActionExecutionScheduler m_ActionExecutionScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_ActionExecutionScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_ActionExecutionScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025E9 RID: 9705
		// (get) Token: 0x06006EC6 RID: 28358 RVA: 0x0020FFA0 File Offset: 0x0020E1A0
		// (set) Token: 0x06006EC7 RID: 28359 RVA: 0x0003BF1F File Offset: 0x0003A11F
		public unsafe GameObject ItemParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_ItemParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_ItemParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025EA RID: 9706
		// (get) Token: 0x06006EC8 RID: 28360 RVA: 0x0020FFD0 File Offset: 0x0020E1D0
		// (set) Token: 0x06006EC9 RID: 28361 RVA: 0x0003BF3E File Offset: 0x0003A13E
		public unsafe SellableDescriber ItemDescriber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_ItemDescriber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_ItemDescriber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025EB RID: 9707
		// (get) Token: 0x06006ECA RID: 28362 RVA: 0x00210000 File Offset: 0x0020E200
		// (set) Token: 0x06006ECB RID: 28363 RVA: 0x0003BF5D File Offset: 0x0003A15D
		public unsafe AdpProgressIndicatorComponent Scroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_Scroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_Scroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025EC RID: 9708
		// (get) Token: 0x06006ECC RID: 28364 RVA: 0x00210030 File Offset: 0x0020E230
		// (set) Token: 0x06006ECD RID: 28365 RVA: 0x0003BF7C File Offset: 0x0003A17C
		public unsafe CanvasGroup DescriberPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_DescriberPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_DescriberPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025ED RID: 9709
		// (get) Token: 0x06006ECE RID: 28366 RVA: 0x00210060 File Offset: 0x0020E260
		// (set) Token: 0x06006ECF RID: 28367 RVA: 0x0003BF9B File Offset: 0x0003A19B
		public unsafe CanvasGroup NullPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_NullPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_NullPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025EE RID: 9710
		// (get) Token: 0x06006ED0 RID: 28368 RVA: 0x00210090 File Offset: 0x0020E290
		// (set) Token: 0x06006ED1 RID: 28369 RVA: 0x0003BFBA File Offset: 0x0003A1BA
		public unsafe UIButtonSimple FilterBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_FilterBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_FilterBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025EF RID: 9711
		// (get) Token: 0x06006ED2 RID: 28370 RVA: 0x002100C0 File Offset: 0x0020E2C0
		// (set) Token: 0x06006ED3 RID: 28371 RVA: 0x0003BFD9 File Offset: 0x0003A1D9
		public unsafe GridLayoutGroup FoodField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_FoodField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_FoodField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F0 RID: 9712
		// (get) Token: 0x06006ED4 RID: 28372 RVA: 0x002100F0 File Offset: 0x0020E2F0
		// (set) Token: 0x06006ED5 RID: 28373 RVA: 0x0003BFF8 File Offset: 0x0003A1F8
		public unsafe GridLayoutGroup BevField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_BevField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_BevField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F1 RID: 9713
		// (get) Token: 0x06006ED6 RID: 28374 RVA: 0x00210120 File Offset: 0x0020E320
		// (set) Token: 0x06006ED7 RID: 28375 RVA: 0x0003C017 File Offset: 0x0003A217
		public unsafe GridLayoutGroup IngField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_IngField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_IngField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F2 RID: 9714
		// (get) Token: 0x06006ED8 RID: 28376 RVA: 0x00210150 File Offset: 0x0020E350
		// (set) Token: 0x06006ED9 RID: 28377 RVA: 0x0003C036 File Offset: 0x0003A236
		public unsafe GridLayoutGroup CookerField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_CookerField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_CookerField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F3 RID: 9715
		// (get) Token: 0x06006EDA RID: 28378 RVA: 0x00210180 File Offset: 0x0020E380
		// (set) Token: 0x06006EDB RID: 28379 RVA: 0x0003C055 File Offset: 0x0003A255
		public unsafe GridLayoutGroup ItemField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_ItemField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_ItemField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F4 RID: 9716
		// (get) Token: 0x06006EDC RID: 28380 RVA: 0x002101B0 File Offset: 0x0020E3B0
		// (set) Token: 0x06006EDD RID: 28381 RVA: 0x0003C074 File Offset: 0x0003A274
		public unsafe TextMeshProUGUI priceText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_priceText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_priceText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F5 RID: 9717
		// (get) Token: 0x06006EDE RID: 28382 RVA: 0x002101E0 File Offset: 0x0020E3E0
		// (set) Token: 0x06006EDF RID: 28383 RVA: 0x0003C093 File Offset: 0x0003A293
		public unsafe List<Sellable> m_Bevs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_Bevs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_Bevs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F6 RID: 9718
		// (get) Token: 0x06006EE0 RID: 28384 RVA: 0x00210210 File Offset: 0x0020E410
		// (set) Token: 0x06006EE1 RID: 28385 RVA: 0x0003C0B2 File Offset: 0x0003A2B2
		public unsafe List<IFilterConfig> m_BevsFilterQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_BevsFilterQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_BevsFilterQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F7 RID: 9719
		// (get) Token: 0x06006EE2 RID: 28386 RVA: 0x00210240 File Offset: 0x0020E440
		// (set) Token: 0x06006EE3 RID: 28387 RVA: 0x0003C0D1 File Offset: 0x0003A2D1
		public unsafe List<Cooker> m_Cookers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_Cookers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Cooker>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_Cookers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F8 RID: 9720
		// (get) Token: 0x06006EE4 RID: 28388 RVA: 0x00210270 File Offset: 0x0020E470
		// (set) Token: 0x06006EE5 RID: 28389 RVA: 0x0003C0F0 File Offset: 0x0003A2F0
		public unsafe List<IFilterConfig> m_CookersFilterQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_CookersFilterQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_CookersFilterQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F9 RID: 9721
		// (get) Token: 0x06006EE6 RID: 28390 RVA: 0x002102A0 File Offset: 0x0020E4A0
		// (set) Token: 0x06006EE7 RID: 28391 RVA: 0x0003C10F File Offset: 0x0003A30F
		public unsafe List<Sellable> m_Foods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_Foods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_Foods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025FA RID: 9722
		// (get) Token: 0x06006EE8 RID: 28392 RVA: 0x002102D0 File Offset: 0x0020E4D0
		// (set) Token: 0x06006EE9 RID: 28393 RVA: 0x0003C12E File Offset: 0x0003A32E
		public unsafe List<IFilterConfig> m_FoodsFilterQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_FoodsFilterQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_FoodsFilterQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025FB RID: 9723
		// (get) Token: 0x06006EEA RID: 28394 RVA: 0x00210300 File Offset: 0x0020E500
		// (set) Token: 0x06006EEB RID: 28395 RVA: 0x0003C14D File Offset: 0x0003A34D
		public unsafe List<Ingredient> m_Ings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_Ings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Ingredient>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_Ings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025FC RID: 9724
		// (get) Token: 0x06006EEC RID: 28396 RVA: 0x00210330 File Offset: 0x0020E530
		// (set) Token: 0x06006EED RID: 28397 RVA: 0x0003C16C File Offset: 0x0003A36C
		public unsafe List<IFilterConfig> m_IngsFilterQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_IngsFilterQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_IngsFilterQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025FD RID: 9725
		// (get) Token: 0x06006EEE RID: 28398 RVA: 0x00210360 File Offset: 0x0020E560
		// (set) Token: 0x06006EEF RID: 28399 RVA: 0x0003C18B File Offset: 0x0003A38B
		public unsafe List<NonTradableObjectBase> m_Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NonTradableObjectBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025FE RID: 9726
		// (get) Token: 0x06006EF0 RID: 28400 RVA: 0x00210390 File Offset: 0x0020E590
		// (set) Token: 0x06006EF1 RID: 28401 RVA: 0x0003C1AA File Offset: 0x0003A3AA
		public unsafe List<IFilterConfig> m_ItemsFilterQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_ItemsFilterQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_ItemsFilterQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025FF RID: 9727
		// (get) Token: 0x06006EF2 RID: 28402 RVA: 0x002103C0 File Offset: 0x0020E5C0
		// (set) Token: 0x06006EF3 RID: 28403 RVA: 0x0003C1C9 File Offset: 0x0003A3C9
		public unsafe Action<NonTradableObjectBase> describeDataCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_describeDataCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NonTradableObjectBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_describeDataCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002600 RID: 9728
		// (get) Token: 0x06006EF4 RID: 28404 RVA: 0x002103F0 File Offset: 0x0020E5F0
		// (set) Token: 0x06006EF5 RID: 28405 RVA: 0x0003C1E8 File Offset: 0x0003A3E8
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<Sellable, UIElementCluster, UIButtonSimple> m_BeverageGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_BeverageGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<Sellable, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_BeverageGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002601 RID: 9729
		// (get) Token: 0x06006EF6 RID: 28406 RVA: 0x00210420 File Offset: 0x0020E620
		// (set) Token: 0x06006EF7 RID: 28407 RVA: 0x0003C207 File Offset: 0x0003A407
		public unsafe CanvasGroup m_BevFieldCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_BevFieldCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_BevFieldCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002602 RID: 9730
		// (get) Token: 0x06006EF8 RID: 28408 RVA: 0x00210450 File Offset: 0x0020E650
		// (set) Token: 0x06006EF9 RID: 28409 RVA: 0x0003C226 File Offset: 0x0003A426
		public unsafe CanvasGroup m_CookerFieldCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_CookerFieldCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_CookerFieldCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002603 RID: 9731
		// (get) Token: 0x06006EFA RID: 28410 RVA: 0x00210480 File Offset: 0x0020E680
		// (set) Token: 0x06006EFB RID: 28411 RVA: 0x0003C245 File Offset: 0x0003A445
		public unsafe Action m_ExitCurrentGroupCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_ExitCurrentGroupCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_ExitCurrentGroupCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002604 RID: 9732
		// (get) Token: 0x06006EFC RID: 28412 RVA: 0x002104B0 File Offset: 0x0020E6B0
		// (set) Token: 0x06006EFD RID: 28413 RVA: 0x0003C264 File Offset: 0x0003A464
		public unsafe CanvasGroup m_FoodFieldCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_FoodFieldCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_FoodFieldCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002605 RID: 9733
		// (get) Token: 0x06006EFE RID: 28414 RVA: 0x002104E0 File Offset: 0x0020E6E0
		// (set) Token: 0x06006EFF RID: 28415 RVA: 0x0003C283 File Offset: 0x0003A483
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<Sellable, UIElementCluster, UIButtonSimple> m_FoodGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_FoodGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<Sellable, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_FoodGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002606 RID: 9734
		// (get) Token: 0x06006F00 RID: 28416 RVA: 0x00210510 File Offset: 0x0020E710
		// (set) Token: 0x06006F01 RID: 28417 RVA: 0x0003C2A2 File Offset: 0x0003A4A2
		public unsafe CanvasGroup m_IngFieldCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_IngFieldCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_IngFieldCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x06006F02 RID: 28418 RVA: 0x00210540 File Offset: 0x0020E740
		// (set) Token: 0x06006F03 RID: 28419 RVA: 0x0003C2C1 File Offset: 0x0003A4C1
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<Ingredient, UIElementCluster, UIButtonSimple> m_IngredientGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_IngredientGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<Ingredient, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_IngredientGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002608 RID: 9736
		// (get) Token: 0x06006F04 RID: 28420 RVA: 0x00210570 File Offset: 0x0020E770
		// (set) Token: 0x06006F05 RID: 28421 RVA: 0x0003C2E0 File Offset: 0x0003A4E0
		public unsafe CanvasGroup m_ItemFieldCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_ItemFieldCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_ItemFieldCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002609 RID: 9737
		// (get) Token: 0x06006F06 RID: 28422 RVA: 0x002105A0 File Offset: 0x0020E7A0
		// (set) Token: 0x06006F07 RID: 28423 RVA: 0x0003C2FF File Offset: 0x0003A4FF
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<NonTradableObjectBase, UIElementCluster, UIButtonSimple> m_ItemGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_ItemGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<NonTradableObjectBase, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_ItemGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700260A RID: 9738
		// (get) Token: 0x06006F08 RID: 28424 RVA: 0x002105D0 File Offset: 0x0020E7D0
		// (set) Token: 0x06006F09 RID: 28425 RVA: 0x0003C31E File Offset: 0x0003A51E
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<Cooker, UIElementCluster, UIButtonSimple> m_KitchenwareGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_KitchenwareGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<Cooker, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_KitchenwareGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700260B RID: 9739
		// (get) Token: 0x06006F0A RID: 28426 RVA: 0x00210600 File Offset: 0x0020E800
		// (set) Token: 0x06006F0B RID: 28427 RVA: 0x0003C33D File Offset: 0x0003A53D
		public unsafe Action m_UpdateObjectCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_UpdateObjectCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.NativeFieldInfoPtr_m_UpdateObjectCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004953 RID: 18771
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionExecutionScheduler;

		// Token: 0x04004954 RID: 18772
		private static readonly IntPtr NativeFieldInfoPtr_ItemParent;

		// Token: 0x04004955 RID: 18773
		private static readonly IntPtr NativeFieldInfoPtr_ItemDescriber;

		// Token: 0x04004956 RID: 18774
		private static readonly IntPtr NativeFieldInfoPtr_Scroller;

		// Token: 0x04004957 RID: 18775
		private static readonly IntPtr NativeFieldInfoPtr_DescriberPannel;

		// Token: 0x04004958 RID: 18776
		private static readonly IntPtr NativeFieldInfoPtr_NullPannel;

		// Token: 0x04004959 RID: 18777
		private static readonly IntPtr NativeFieldInfoPtr_FilterBtn;

		// Token: 0x0400495A RID: 18778
		private static readonly IntPtr NativeFieldInfoPtr_FoodField;

		// Token: 0x0400495B RID: 18779
		private static readonly IntPtr NativeFieldInfoPtr_BevField;

		// Token: 0x0400495C RID: 18780
		private static readonly IntPtr NativeFieldInfoPtr_IngField;

		// Token: 0x0400495D RID: 18781
		private static readonly IntPtr NativeFieldInfoPtr_CookerField;

		// Token: 0x0400495E RID: 18782
		private static readonly IntPtr NativeFieldInfoPtr_ItemField;

		// Token: 0x0400495F RID: 18783
		private static readonly IntPtr NativeFieldInfoPtr_priceText;

		// Token: 0x04004960 RID: 18784
		private static readonly IntPtr NativeFieldInfoPtr_m_Bevs;

		// Token: 0x04004961 RID: 18785
		private static readonly IntPtr NativeFieldInfoPtr_m_BevsFilterQueue;

		// Token: 0x04004962 RID: 18786
		private static readonly IntPtr NativeFieldInfoPtr_m_Cookers;

		// Token: 0x04004963 RID: 18787
		private static readonly IntPtr NativeFieldInfoPtr_m_CookersFilterQueue;

		// Token: 0x04004964 RID: 18788
		private static readonly IntPtr NativeFieldInfoPtr_m_Foods;

		// Token: 0x04004965 RID: 18789
		private static readonly IntPtr NativeFieldInfoPtr_m_FoodsFilterQueue;

		// Token: 0x04004966 RID: 18790
		private static readonly IntPtr NativeFieldInfoPtr_m_Ings;

		// Token: 0x04004967 RID: 18791
		private static readonly IntPtr NativeFieldInfoPtr_m_IngsFilterQueue;

		// Token: 0x04004968 RID: 18792
		private static readonly IntPtr NativeFieldInfoPtr_m_Items;

		// Token: 0x04004969 RID: 18793
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemsFilterQueue;

		// Token: 0x0400496A RID: 18794
		private static readonly IntPtr NativeFieldInfoPtr_describeDataCallback;

		// Token: 0x0400496B RID: 18795
		private static readonly IntPtr NativeFieldInfoPtr_m_BeverageGroup;

		// Token: 0x0400496C RID: 18796
		private static readonly IntPtr NativeFieldInfoPtr_m_BevFieldCanvasGroup;

		// Token: 0x0400496D RID: 18797
		private static readonly IntPtr NativeFieldInfoPtr_m_CookerFieldCanvasGroup;

		// Token: 0x0400496E RID: 18798
		private static readonly IntPtr NativeFieldInfoPtr_m_ExitCurrentGroupCallback;

		// Token: 0x0400496F RID: 18799
		private static readonly IntPtr NativeFieldInfoPtr_m_FoodFieldCanvasGroup;

		// Token: 0x04004970 RID: 18800
		private static readonly IntPtr NativeFieldInfoPtr_m_FoodGroup;

		// Token: 0x04004971 RID: 18801
		private static readonly IntPtr NativeFieldInfoPtr_m_IngFieldCanvasGroup;

		// Token: 0x04004972 RID: 18802
		private static readonly IntPtr NativeFieldInfoPtr_m_IngredientGroup;

		// Token: 0x04004973 RID: 18803
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemFieldCanvasGroup;

		// Token: 0x04004974 RID: 18804
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemGroup;

		// Token: 0x04004975 RID: 18805
		private static readonly IntPtr NativeFieldInfoPtr_m_KitchenwareGroup;

		// Token: 0x04004976 RID: 18806
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateObjectCallback;

		// Token: 0x04004977 RID: 18807
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04004978 RID: 18808
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004979 RID: 18809
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x0400497A RID: 18810
		private static readonly IntPtr NativeMethodInfoPtr_ResetFilter_Private_Void_0;

		// Token: 0x0400497B RID: 18811
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x0400497C RID: 18812
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x0400497D RID: 18813
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400497E RID: 18814
		private static readonly IntPtr NativeMethodInfoPtr_SetParamValue_Private_Void_Action_1_NonTradableObjectBase_0;

		// Token: 0x0400497F RID: 18815
		private static readonly IntPtr NativeMethodInfoPtr_OnElementEnabled_Private_Void_T_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004980 RID: 18816
		private static readonly IntPtr NativeMethodInfoPtr_OnElementSelected_Private_Void_T_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004981 RID: 18817
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004982 RID: 18818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004983 RID: 18819
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__38_0_Private_Void_0;

		// Token: 0x04004984 RID: 18820
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_UniTask_0;

		// Token: 0x04004985 RID: 18821
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_0_Private_Void_0;

		// Token: 0x04004986 RID: 18822
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_1_Private_Void_0;

		// Token: 0x04004987 RID: 18823
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_10_Private_Void_NonTradableObjectBase_0;

		// Token: 0x04004988 RID: 18824
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_2_Private_Void_0;

		// Token: 0x04004989 RID: 18825
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_3_Private_Void_0;

		// Token: 0x0400498A RID: 18826
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_11_Private_Void_NonTradableObjectBase_0;

		// Token: 0x0400498B RID: 18827
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_4_Private_Void_0;

		// Token: 0x0400498C RID: 18828
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_5_Private_Void_0;

		// Token: 0x0400498D RID: 18829
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_12_Private_Void_NonTradableObjectBase_0;

		// Token: 0x0400498E RID: 18830
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_6_Private_Void_0;

		// Token: 0x0400498F RID: 18831
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_7_Private_Void_0;

		// Token: 0x04004990 RID: 18832
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_14_Private_Void_NonTradableObjectBase_0;

		// Token: 0x04004991 RID: 18833
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_8_Private_Void_0;

		// Token: 0x04004992 RID: 18834
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_9_Private_Void_0;

		// Token: 0x04004993 RID: 18835
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_15_Private_Void_NonTradableObjectBase_0;

		// Token: 0x02000ED6 RID: 3798
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookAlbumItemSubPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010B52 RID: 68434 RVA: 0x003DDBA0 File Offset: 0x003DBDA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c>.NativeClassPtr);
				NoteBookAlbumItemSubPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c>.NativeClassPtr, "<>9");
				NoteBookAlbumItemSubPannel.__c.NativeFieldInfoPtr___9__43_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c>.NativeClassPtr, "<>9__43_13");
				NoteBookAlbumItemSubPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c>.NativeClassPtr, 100685961);
				NoteBookAlbumItemSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_13_Internal_Int32_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c>.NativeClassPtr, 100685962);
			}

			// Token: 0x06010B53 RID: 68435 RVA: 0x003DDC1C File Offset: 0x003DBE1C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B54 RID: 68436 RVA: 0x003DDC58 File Offset: 0x003DBE58
			[CallerCount(0)]
			public unsafe int _OnPanelOpen_b__43_13(Cooker x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_13_Internal_Int32_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010B55 RID: 68437 RVA: 0x00091AF1 File Offset: 0x0008FCF1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005715 RID: 22293
			// (get) Token: 0x06010B56 RID: 68438 RVA: 0x003DDCA8 File Offset: 0x003DBEA8
			// (set) Token: 0x06010B57 RID: 68439 RVA: 0x00091AFA File Offset: 0x0008FCFA
			public unsafe static NoteBookAlbumItemSubPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumItemSubPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookAlbumItemSubPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumItemSubPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005716 RID: 22294
			// (get) Token: 0x06010B58 RID: 68440 RVA: 0x003DDCD0 File Offset: 0x003DBED0
			// (set) Token: 0x06010B59 RID: 68441 RVA: 0x00091B0C File Offset: 0x0008FD0C
			public unsafe static Func<Cooker, int> __9__43_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookAlbumItemSubPannel.__c.NativeFieldInfoPtr___9__43_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Cooker, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookAlbumItemSubPannel.__c.NativeFieldInfoPtr___9__43_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A909 RID: 43273
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A90A RID: 43274
			private static readonly IntPtr NativeFieldInfoPtr___9__43_13;

			// Token: 0x0400A90B RID: 43275
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A90C RID: 43276
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_13_Internal_Int32_Cooker_0;
		}

		// Token: 0x02000ED7 RID: 3799
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookAlbumItemSubPannel+<>c__DisplayClass45_0`1")]
		public sealed class __c__DisplayClass45_0<T> : Il2CppSystem.Object where T : NonTradableObjectBase
		{
			// Token: 0x06010B5A RID: 68442 RVA: 0x003DDCF8 File Offset: 0x003DBEF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass45_0()
			{
				Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c__DisplayClass45_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "<>c__DisplayClass45_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c__DisplayClass45_0<T>>.NativeClassPtr);
				NoteBookAlbumItemSubPannel.__c__DisplayClass45_0<T>.NativeFieldInfoPtr_objectBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c__DisplayClass45_0<T>>.NativeClassPtr, "objectBase");
				NoteBookAlbumItemSubPannel.__c__DisplayClass45_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c__DisplayClass45_0<T>>.NativeClassPtr, 100685963);
				NoteBookAlbumItemSubPannel.__c__DisplayClass45_0<T>.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c__DisplayClass45_0<T>>.NativeClassPtr, 100685964);
			}

			// Token: 0x06010B5B RID: 68443 RVA: 0x003DDD9C File Offset: 0x003DBF9C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass45_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c__DisplayClass45_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.__c__DisplayClass45_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B5C RID: 68444 RVA: 0x003DDDD8 File Offset: 0x003DBFD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.__c__DisplayClass45_0<T>.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B5D RID: 68445 RVA: 0x00091B1E File Offset: 0x0008FD1E
			public __c__DisplayClass45_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005717 RID: 22295
			// (get) Token: 0x06010B5E RID: 68446 RVA: 0x003DDE1C File Offset: 0x003DC01C
			// (set) Token: 0x06010B5F RID: 68447 RVA: 0x003DDE44 File Offset: 0x003DC044
			public unsafe T objectBase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.__c__DisplayClass45_0<T>.NativeFieldInfoPtr_objectBase);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.__c__DisplayClass45_0<T>.NativeFieldInfoPtr_objectBase);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x0400A90D RID: 43277
			private static readonly IntPtr NativeFieldInfoPtr_objectBase;

			// Token: 0x0400A90E RID: 43278
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A90F RID: 43279
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0;
		}

		// Token: 0x02000ED8 RID: 3800
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookAlbumItemSubPannel+<>c__DisplayClass46_0`1")]
		public sealed class __c__DisplayClass46_0<T> : Il2CppSystem.Object where T : NonTradableObjectBase
		{
			// Token: 0x06010B60 RID: 68448 RVA: 0x003DDEEC File Offset: 0x003DC0EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass46_0()
			{
				Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c__DisplayClass46_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "<>c__DisplayClass46_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c__DisplayClass46_0<T>>.NativeClassPtr);
				NoteBookAlbumItemSubPannel.__c__DisplayClass46_0<T>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c__DisplayClass46_0<T>>.NativeClassPtr, "<>4__this");
				NoteBookAlbumItemSubPannel.__c__DisplayClass46_0<T>.NativeFieldInfoPtr_objectBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c__DisplayClass46_0<T>>.NativeClassPtr, "objectBase");
				NoteBookAlbumItemSubPannel.__c__DisplayClass46_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c__DisplayClass46_0<T>>.NativeClassPtr, 100685965);
				NoteBookAlbumItemSubPannel.__c__DisplayClass46_0<T>.NativeMethodInfoPtr__OnElementSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c__DisplayClass46_0<T>>.NativeClassPtr, 100685966);
			}

			// Token: 0x06010B61 RID: 68449 RVA: 0x003DDFA4 File Offset: 0x003DC1A4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass46_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.__c__DisplayClass46_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.__c__DisplayClass46_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B62 RID: 68450 RVA: 0x003DDFE0 File Offset: 0x003DC1E0
			[CallerCount(0)]
			public unsafe void _OnElementSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.__c__DisplayClass46_0<T>.NativeMethodInfoPtr__OnElementSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B63 RID: 68451 RVA: 0x00091B27 File Offset: 0x0008FD27
			public __c__DisplayClass46_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005718 RID: 22296
			// (get) Token: 0x06010B64 RID: 68452 RVA: 0x003DE014 File Offset: 0x003DC214
			// (set) Token: 0x06010B65 RID: 68453 RVA: 0x00091B30 File Offset: 0x0008FD30
			public unsafe NoteBookAlbumItemSubPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.__c__DisplayClass46_0<T>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookAlbumItemSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.__c__DisplayClass46_0<T>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005719 RID: 22297
			// (get) Token: 0x06010B66 RID: 68454 RVA: 0x003DE044 File Offset: 0x003DC244
			// (set) Token: 0x06010B67 RID: 68455 RVA: 0x003DE06C File Offset: 0x003DC26C
			public unsafe T objectBase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.__c__DisplayClass46_0<T>.NativeFieldInfoPtr_objectBase);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.__c__DisplayClass46_0<T>.NativeFieldInfoPtr_objectBase);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x0400A910 RID: 43280
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A911 RID: 43281
			private static readonly IntPtr NativeFieldInfoPtr_objectBase;

			// Token: 0x0400A912 RID: 43282
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A913 RID: 43283
			private static readonly IntPtr NativeMethodInfoPtr__OnElementSelected_b__0_Internal_Void_0;
		}

		// Token: 0x02000ED9 RID: 3801
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookAlbumItemSubPannel+<<OnPanelInitialize>g__OpenFilterPanel|38_1>d")]
		public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique : ValueType
		{
			// Token: 0x06010B68 RID: 68456 RVA: 0x003DE114 File Offset: 0x003DC314
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique()
			{
				Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr, "<<OnPanelInitialize>g__OpenFilterPanel|38_1>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique>.NativeClassPtr);
				NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique>.NativeClassPtr, "<>1__state");
				NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique>.NativeClassPtr, "<>t__builder");
				NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique>.NativeClassPtr, "<>4__this");
				NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique>.NativeClassPtr, "<>u__1");
				NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique>.NativeClassPtr, 100685967);
				NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique>.NativeClassPtr, 100685968);
			}

			// Token: 0x06010B69 RID: 68457 RVA: 0x003DE1B8 File Offset: 0x003DC3B8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 277121, RefRangeEnd = 277123, XrefRangeStart = 277014, XrefRangeEnd = 277121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B6A RID: 68458 RVA: 0x003DE1F0 File Offset: 0x003DC3F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B6B RID: 68459 RVA: 0x00091B4F File Offset: 0x0008FD4F
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010B6C RID: 68460 RVA: 0x00091B58 File Offset: 0x0008FD58
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique>.NativeClassPtr))
			{
			}

			// Token: 0x1700571A RID: 22298
			// (get) Token: 0x06010B6D RID: 68461 RVA: 0x003DE238 File Offset: 0x003DC438
			// (set) Token: 0x06010B6E RID: 68462 RVA: 0x00091B6A File Offset: 0x0008FD6A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700571B RID: 22299
			// (get) Token: 0x06010B6F RID: 68463 RVA: 0x003DE260 File Offset: 0x003DC460
			// (set) Token: 0x06010B70 RID: 68464 RVA: 0x00091B85 File Offset: 0x0008FD85
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700571C RID: 22300
			// (get) Token: 0x06010B71 RID: 68465 RVA: 0x003DE290 File Offset: 0x003DC490
			// (set) Token: 0x06010B72 RID: 68466 RVA: 0x00091BB3 File Offset: 0x0008FDB3
			public unsafe NoteBookAlbumItemSubPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookAlbumItemSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700571D RID: 22301
			// (get) Token: 0x06010B73 RID: 68467 RVA: 0x003DE2C0 File Offset: 0x003DC4C0
			// (set) Token: 0x06010B74 RID: 68468 RVA: 0x00091BD2 File Offset: 0x0008FDD2
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookAlbumItemSubPannel.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsNoAwUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A914 RID: 43284
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A915 RID: 43285
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A916 RID: 43286
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A917 RID: 43287
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A918 RID: 43288
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A919 RID: 43289
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000EDA RID: 3802
		private sealed class MethodInfoStoreGeneric_OnElementEnabled_Private_Void_T_UIElementCluster_UIButtonSimple_0<T>
		{
			// Token: 0x0400A91A RID: 43290
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_T_UIElementCluster_UIButtonSimple_0, Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000EDB RID: 3803
		private sealed class MethodInfoStoreGeneric_OnElementSelected_Private_Void_T_UIElementCluster_UIButtonSimple_0<T>
		{
			// Token: 0x0400A91B RID: 43291
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NoteBookAlbumItemSubPannel.NativeMethodInfoPtr_OnElementSelected_Private_Void_T_UIElementCluster_UIButtonSimple_0, Il2CppClassPointerStore<NoteBookAlbumItemSubPannel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
