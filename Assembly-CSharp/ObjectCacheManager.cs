using System;
using Common.Effects;
using DEYU.Singletons;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using NightScene.UI;
using NightScene.UI.GuestManagementUtility;
using UnityEngine;

// Token: 0x02000010 RID: 16
public class ObjectCacheManager : MonoSingleton<ObjectCacheManager>
{
	// Token: 0x060000FE RID: 254 RVA: 0x000A2238 File Offset: 0x000A0438
	// Note: this type is marked as 'beforefieldinit'.
	static ObjectCacheManager()
	{
		Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ObjectCacheManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr);
		ObjectCacheManager.NativeFieldInfoPtr_dialogBoxParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, "dialogBoxParent");
		ObjectCacheManager.NativeFieldInfoPtr_evaluationBoxParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, "evaluationBoxParent");
		ObjectCacheManager.NativeFieldInfoPtr_throwDeliverParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, "throwDeliverParent");
		ObjectCacheManager.NativeFieldInfoPtr_tipCoinParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, "tipCoinParent");
		ObjectCacheManager.NativeFieldInfoPtr_orderingElementParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, "orderingElementParent");
		ObjectCacheManager.NativeFieldInfoPtr_ghostOrderingElementParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, "ghostOrderingElementParent");
		ObjectCacheManager.NativeFieldInfoPtr_allNormalDialogInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, "allNormalDialogInstances");
		ObjectCacheManager.NativeFieldInfoPtr_allEvaluationDialogInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, "allEvaluationDialogInstances");
		ObjectCacheManager.NativeFieldInfoPtr_allThrowDeliverObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, "allThrowDeliverObjects");
		ObjectCacheManager.NativeFieldInfoPtr_allTipCoinObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, "allTipCoinObjects");
		ObjectCacheManager.NativeFieldInfoPtr_allOrderElementObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, "allOrderElementObjects");
		ObjectCacheManager.NativeFieldInfoPtr_allGhostOrderElementObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, "allGhostOrderElementObjects");
		ObjectCacheManager.NativeFieldInfoPtr_uiManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, "uiManager");
		ObjectCacheManager.NativeMethodInfoPtr_CreateNewNormalDialog_Private_DialogBoxUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663406);
		ObjectCacheManager.NativeMethodInfoPtr_CreateNewEvaluationDialog_Private_EvalulationBoxUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663407);
		ObjectCacheManager.NativeMethodInfoPtr_CreateNewThrowDeliverObject_Private_ControllableLaunchAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663408);
		ObjectCacheManager.NativeMethodInfoPtr_CreateNewTipCoinObject_Private_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663409);
		ObjectCacheManager.NativeMethodInfoPtr_CreateOrderingElement_Private_OrderingElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663410);
		ObjectCacheManager.NativeMethodInfoPtr_CreateGhostOrderingElement_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663411);
		ObjectCacheManager.NativeMethodInfoPtr_GetNormalDialogBoxUI_Public_DialogBoxUI_byref_Action_1_DialogBoxUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663412);
		ObjectCacheManager.NativeMethodInfoPtr_GetNewEvaluationDialog_Public_EvalulationBoxUI_byref_Action_1_EvalulationBoxUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663413);
		ObjectCacheManager.NativeMethodInfoPtr_GetNewThrowDeliverObject_Public_ControllableLaunchAnimation_byref_Action_1_ControllableLaunchAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663414);
		ObjectCacheManager.NativeMethodInfoPtr_GetNewTipCoinObject_Public_GameObject_byref_Action_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663415);
		ObjectCacheManager.NativeMethodInfoPtr_GetOrderingElement_Public_OrderingElement_byref_Action_1_OrderingElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663416);
		ObjectCacheManager.NativeMethodInfoPtr_GetGhostOrderingElement_Public_Transform_byref_Action_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663417);
		ObjectCacheManager.NativeMethodInfoPtr_InitializeAndPreload_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663418);
		ObjectCacheManager.NativeMethodInfoPtr_CleanupCache_Private_Static_Void_Stack_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663419);
		ObjectCacheManager.NativeMethodInfoPtr_CleanupCache_Private_Static_Void_Stack_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663420);
		ObjectCacheManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663421);
		ObjectCacheManager.NativeMethodInfoPtr_GetCacheData_Private_T_Stack_1_T_Func_1_T_byref_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663422);
		ObjectCacheManager.NativeMethodInfoPtr_Preload_Private_Void_PreloadCacheMethod_1_T_CachedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663423);
		ObjectCacheManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663424);
		ObjectCacheManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, 100663425);
	}

	// Token: 0x060000FF RID: 255 RVA: 0x000A24FC File Offset: 0x000A06FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3626, XrefRangeEnd = 3639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DialogBoxUI CreateNewNormalDialog()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.NativeMethodInfoPtr_CreateNewNormalDialog_Private_DialogBoxUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogBoxUI>(intPtr3) : null;
	}

	// Token: 0x06000100 RID: 256 RVA: 0x000A253C File Offset: 0x000A073C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3639, XrefRangeEnd = 3652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EvalulationBoxUI CreateNewEvaluationDialog()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.NativeMethodInfoPtr_CreateNewEvaluationDialog_Private_EvalulationBoxUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<EvalulationBoxUI>(intPtr3) : null;
	}

	// Token: 0x06000101 RID: 257 RVA: 0x000A257C File Offset: 0x000A077C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3652, XrefRangeEnd = 3666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControllableLaunchAnimation CreateNewThrowDeliverObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.NativeMethodInfoPtr_CreateNewThrowDeliverObject_Private_ControllableLaunchAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllableLaunchAnimation>(intPtr3) : null;
	}

	// Token: 0x06000102 RID: 258 RVA: 0x000A25BC File Offset: 0x000A07BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3666, XrefRangeEnd = 3673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject CreateNewTipCoinObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.NativeMethodInfoPtr_CreateNewTipCoinObject_Private_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x06000103 RID: 259 RVA: 0x000A25FC File Offset: 0x000A07FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3673, XrefRangeEnd = 3687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OrderingElement CreateOrderingElement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.NativeMethodInfoPtr_CreateOrderingElement_Private_OrderingElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<OrderingElement>(intPtr3) : null;
	}

	// Token: 0x06000104 RID: 260 RVA: 0x000A263C File Offset: 0x000A083C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3687, XrefRangeEnd = 3697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform CreateGhostOrderingElement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.NativeMethodInfoPtr_CreateGhostOrderingElement_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
	}

	// Token: 0x06000105 RID: 261 RVA: 0x000A267C File Offset: 0x000A087C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3706, RefRangeEnd = 3708, XrefRangeStart = 3697, XrefRangeEnd = 3706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DialogBoxUI GetNormalDialogBoxUI(out Action<DialogBoxUI> pushCallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		ref IntPtr ptr2 = ref *ptr;
		IntPtr intPtr = 0;
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.NativeMethodInfoPtr_GetNormalDialogBoxUI_Public_DialogBoxUI_byref_Action_1_DialogBoxUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		pushCallback = ((intPtr4 == 0) ? null : new Action<DialogBoxUI>(intPtr4));
		IntPtr intPtr5 = intPtr2;
		return (intPtr5 != 0) ? Il2CppObjectPool.Get<DialogBoxUI>(intPtr5) : null;
	}

	// Token: 0x06000106 RID: 262 RVA: 0x000A26E0 File Offset: 0x000A08E0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3717, RefRangeEnd = 3719, XrefRangeStart = 3708, XrefRangeEnd = 3717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EvalulationBoxUI GetNewEvaluationDialog(out Action<EvalulationBoxUI> pushCallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		ref IntPtr ptr2 = ref *ptr;
		IntPtr intPtr = 0;
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.NativeMethodInfoPtr_GetNewEvaluationDialog_Public_EvalulationBoxUI_byref_Action_1_EvalulationBoxUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		pushCallback = ((intPtr4 == 0) ? null : new Action<EvalulationBoxUI>(intPtr4));
		IntPtr intPtr5 = intPtr2;
		return (intPtr5 != 0) ? Il2CppObjectPool.Get<EvalulationBoxUI>(intPtr5) : null;
	}

	// Token: 0x06000107 RID: 263 RVA: 0x000A2744 File Offset: 0x000A0944
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3728, RefRangeEnd = 3729, XrefRangeStart = 3719, XrefRangeEnd = 3728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControllableLaunchAnimation GetNewThrowDeliverObject(out Action<ControllableLaunchAnimation> pushCallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		ref IntPtr ptr2 = ref *ptr;
		IntPtr intPtr = 0;
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.NativeMethodInfoPtr_GetNewThrowDeliverObject_Public_ControllableLaunchAnimation_byref_Action_1_ControllableLaunchAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		pushCallback = ((intPtr4 == 0) ? null : new Action<ControllableLaunchAnimation>(intPtr4));
		IntPtr intPtr5 = intPtr2;
		return (intPtr5 != 0) ? Il2CppObjectPool.Get<ControllableLaunchAnimation>(intPtr5) : null;
	}

	// Token: 0x06000108 RID: 264 RVA: 0x000A27A8 File Offset: 0x000A09A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3729, XrefRangeEnd = 3738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetNewTipCoinObject(out Action<GameObject> pushCallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		ref IntPtr ptr2 = ref *ptr;
		IntPtr intPtr = 0;
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.NativeMethodInfoPtr_GetNewTipCoinObject_Public_GameObject_byref_Action_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		pushCallback = ((intPtr4 == 0) ? null : new Action<GameObject>(intPtr4));
		IntPtr intPtr5 = intPtr2;
		return (intPtr5 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr5) : null;
	}

	// Token: 0x06000109 RID: 265 RVA: 0x000A280C File Offset: 0x000A0A0C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3747, RefRangeEnd = 3748, XrefRangeStart = 3738, XrefRangeEnd = 3747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OrderingElement GetOrderingElement(out Action<OrderingElement> pushCallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		ref IntPtr ptr2 = ref *ptr;
		IntPtr intPtr = 0;
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.NativeMethodInfoPtr_GetOrderingElement_Public_OrderingElement_byref_Action_1_OrderingElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		pushCallback = ((intPtr4 == 0) ? null : new Action<OrderingElement>(intPtr4));
		IntPtr intPtr5 = intPtr2;
		return (intPtr5 != 0) ? Il2CppObjectPool.Get<OrderingElement>(intPtr5) : null;
	}

	// Token: 0x0600010A RID: 266 RVA: 0x000A2870 File Offset: 0x000A0A70
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3757, RefRangeEnd = 3758, XrefRangeStart = 3748, XrefRangeEnd = 3757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform GetGhostOrderingElement(out Action<Transform> pushCallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		ref IntPtr ptr2 = ref *ptr;
		IntPtr intPtr = 0;
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.NativeMethodInfoPtr_GetGhostOrderingElement_Public_Transform_byref_Action_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		pushCallback = ((intPtr4 == 0) ? null : new Action<Transform>(intPtr4));
		IntPtr intPtr5 = intPtr2;
		return (intPtr5 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr5) : null;
	}

	// Token: 0x0600010B RID: 267 RVA: 0x000A28D4 File Offset: 0x000A0AD4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3816, RefRangeEnd = 3817, XrefRangeStart = 3758, XrefRangeEnd = 3816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeAndPreload()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.NativeMethodInfoPtr_InitializeAndPreload_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600010C RID: 268 RVA: 0x000A2908 File Offset: 0x000A0B08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3817, XrefRangeEnd = 3825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CleanupCache(Stack<GameObject> cached)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cached);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.NativeMethodInfoPtr_CleanupCache_Private_Static_Void_Stack_1_GameObject_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600010D RID: 269 RVA: 0x000A2940 File Offset: 0x000A0B40
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 3834, RefRangeEnd = 3839, XrefRangeStart = 3825, XrefRangeEnd = 3834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CleanupCache<T>(Stack<T> cached) where T : Component
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cached);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.MethodInfoStoreGeneric_CleanupCache_Private_Static_Void_Stack_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600010E RID: 270 RVA: 0x000A2978 File Offset: 0x000A0B78
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3839, XrefRangeEnd = 3866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnInstanceDestroyed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectCacheManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600010F RID: 271 RVA: 0x000A29B4 File Offset: 0x000A0BB4
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 3870, RefRangeEnd = 3876, XrefRangeStart = 3866, XrefRangeEnd = 3870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T GetCacheData<T>(Stack<T> targetStack, Func<T> createCallback, out Action<T> pushCallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetStack);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createCallback);
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = 0;
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.MethodInfoStoreGeneric_GetCacheData_Private_T_Stack_1_T_Func_1_T_byref_Action_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		pushCallback = ((intPtr4 == 0) ? null : new Action<T>(intPtr4));
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	// Token: 0x06000110 RID: 272 RVA: 0x000A2A34 File Offset: 0x000A0C34
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 3885, RefRangeEnd = 3891, XrefRangeStart = 3876, XrefRangeEnd = 3885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Preload<T>(ObjectCacheManager.PreloadCacheMethod<T> preloadMethod, ObjectCacheManager.CachedObject cachedObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(preloadMethod);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cachedObject));
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.MethodInfoStoreGeneric_Preload_Private_Void_PreloadCacheMethod_1_T_CachedObject_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000111 RID: 273 RVA: 0x000A2A90 File Offset: 0x000A0C90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3891, XrefRangeEnd = 3910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Cleanup_Generated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectCacheManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000112 RID: 274 RVA: 0x000A2ACC File Offset: 0x000A0CCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3910, XrefRangeEnd = 3956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObjectCacheManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000113 RID: 275 RVA: 0x0000276F File Offset: 0x0000096F
	public ObjectCacheManager(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x06000114 RID: 276 RVA: 0x000A2B08 File Offset: 0x000A0D08
	// (set) Token: 0x06000115 RID: 277 RVA: 0x00002778 File Offset: 0x00000978
	public ObjectCacheManager.CachedObject dialogBoxParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_dialogBoxParent);
			return new ObjectCacheManager.CachedObject(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObjectCacheManager.CachedObject>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_dialogBoxParent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ObjectCacheManager.CachedObject>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000116 RID: 278 RVA: 0x000A2B38 File Offset: 0x000A0D38
	// (set) Token: 0x06000117 RID: 279 RVA: 0x000027A6 File Offset: 0x000009A6
	public ObjectCacheManager.CachedObject evaluationBoxParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_evaluationBoxParent);
			return new ObjectCacheManager.CachedObject(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObjectCacheManager.CachedObject>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_evaluationBoxParent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ObjectCacheManager.CachedObject>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06000118 RID: 280 RVA: 0x000A2B68 File Offset: 0x000A0D68
	// (set) Token: 0x06000119 RID: 281 RVA: 0x000027D4 File Offset: 0x000009D4
	public ObjectCacheManager.CachedObject throwDeliverParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_throwDeliverParent);
			return new ObjectCacheManager.CachedObject(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObjectCacheManager.CachedObject>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_throwDeliverParent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ObjectCacheManager.CachedObject>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x0600011A RID: 282 RVA: 0x000A2B98 File Offset: 0x000A0D98
	// (set) Token: 0x0600011B RID: 283 RVA: 0x00002802 File Offset: 0x00000A02
	public ObjectCacheManager.CachedObject tipCoinParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_tipCoinParent);
			return new ObjectCacheManager.CachedObject(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObjectCacheManager.CachedObject>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_tipCoinParent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ObjectCacheManager.CachedObject>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x0600011C RID: 284 RVA: 0x000A2BC8 File Offset: 0x000A0DC8
	// (set) Token: 0x0600011D RID: 285 RVA: 0x00002830 File Offset: 0x00000A30
	public ObjectCacheManager.CachedObject orderingElementParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_orderingElementParent);
			return new ObjectCacheManager.CachedObject(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObjectCacheManager.CachedObject>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_orderingElementParent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ObjectCacheManager.CachedObject>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x0600011E RID: 286 RVA: 0x000A2BF8 File Offset: 0x000A0DF8
	// (set) Token: 0x0600011F RID: 287 RVA: 0x0000285E File Offset: 0x00000A5E
	public ObjectCacheManager.CachedObject ghostOrderingElementParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_ghostOrderingElementParent);
			return new ObjectCacheManager.CachedObject(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObjectCacheManager.CachedObject>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_ghostOrderingElementParent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ObjectCacheManager.CachedObject>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06000120 RID: 288 RVA: 0x000A2C28 File Offset: 0x000A0E28
	// (set) Token: 0x06000121 RID: 289 RVA: 0x0000288C File Offset: 0x00000A8C
	public unsafe Stack<DialogBoxUI> allNormalDialogInstances
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_allNormalDialogInstances);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<DialogBoxUI>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_allNormalDialogInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x06000122 RID: 290 RVA: 0x000A2C58 File Offset: 0x000A0E58
	// (set) Token: 0x06000123 RID: 291 RVA: 0x000028AB File Offset: 0x00000AAB
	public unsafe Stack<EvalulationBoxUI> allEvaluationDialogInstances
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_allEvaluationDialogInstances);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<EvalulationBoxUI>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_allEvaluationDialogInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x06000124 RID: 292 RVA: 0x000A2C88 File Offset: 0x000A0E88
	// (set) Token: 0x06000125 RID: 293 RVA: 0x000028CA File Offset: 0x00000ACA
	public unsafe Stack<ControllableLaunchAnimation> allThrowDeliverObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_allThrowDeliverObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ControllableLaunchAnimation>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_allThrowDeliverObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x06000126 RID: 294 RVA: 0x000A2CB8 File Offset: 0x000A0EB8
	// (set) Token: 0x06000127 RID: 295 RVA: 0x000028E9 File Offset: 0x00000AE9
	public unsafe Stack<GameObject> allTipCoinObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_allTipCoinObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_allTipCoinObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x06000128 RID: 296 RVA: 0x000A2CE8 File Offset: 0x000A0EE8
	// (set) Token: 0x06000129 RID: 297 RVA: 0x00002908 File Offset: 0x00000B08
	public unsafe Stack<OrderingElement> allOrderElementObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_allOrderElementObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<OrderingElement>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_allOrderElementObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x0600012A RID: 298 RVA: 0x000A2D18 File Offset: 0x000A0F18
	// (set) Token: 0x0600012B RID: 299 RVA: 0x00002927 File Offset: 0x00000B27
	public unsafe Stack<Transform> allGhostOrderElementObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_allGhostOrderElementObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<Transform>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_allGhostOrderElementObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x0600012C RID: 300 RVA: 0x000A2D48 File Offset: 0x000A0F48
	// (set) Token: 0x0600012D RID: 301 RVA: 0x00002946 File Offset: 0x00000B46
	public unsafe UIManager uiManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_uiManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.NativeFieldInfoPtr_uiManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040000A1 RID: 161
	private static readonly IntPtr NativeFieldInfoPtr_dialogBoxParent;

	// Token: 0x040000A2 RID: 162
	private static readonly IntPtr NativeFieldInfoPtr_evaluationBoxParent;

	// Token: 0x040000A3 RID: 163
	private static readonly IntPtr NativeFieldInfoPtr_throwDeliverParent;

	// Token: 0x040000A4 RID: 164
	private static readonly IntPtr NativeFieldInfoPtr_tipCoinParent;

	// Token: 0x040000A5 RID: 165
	private static readonly IntPtr NativeFieldInfoPtr_orderingElementParent;

	// Token: 0x040000A6 RID: 166
	private static readonly IntPtr NativeFieldInfoPtr_ghostOrderingElementParent;

	// Token: 0x040000A7 RID: 167
	private static readonly IntPtr NativeFieldInfoPtr_allNormalDialogInstances;

	// Token: 0x040000A8 RID: 168
	private static readonly IntPtr NativeFieldInfoPtr_allEvaluationDialogInstances;

	// Token: 0x040000A9 RID: 169
	private static readonly IntPtr NativeFieldInfoPtr_allThrowDeliverObjects;

	// Token: 0x040000AA RID: 170
	private static readonly IntPtr NativeFieldInfoPtr_allTipCoinObjects;

	// Token: 0x040000AB RID: 171
	private static readonly IntPtr NativeFieldInfoPtr_allOrderElementObjects;

	// Token: 0x040000AC RID: 172
	private static readonly IntPtr NativeFieldInfoPtr_allGhostOrderElementObjects;

	// Token: 0x040000AD RID: 173
	private static readonly IntPtr NativeFieldInfoPtr_uiManager;

	// Token: 0x040000AE RID: 174
	private static readonly IntPtr NativeMethodInfoPtr_CreateNewNormalDialog_Private_DialogBoxUI_0;

	// Token: 0x040000AF RID: 175
	private static readonly IntPtr NativeMethodInfoPtr_CreateNewEvaluationDialog_Private_EvalulationBoxUI_0;

	// Token: 0x040000B0 RID: 176
	private static readonly IntPtr NativeMethodInfoPtr_CreateNewThrowDeliverObject_Private_ControllableLaunchAnimation_0;

	// Token: 0x040000B1 RID: 177
	private static readonly IntPtr NativeMethodInfoPtr_CreateNewTipCoinObject_Private_GameObject_0;

	// Token: 0x040000B2 RID: 178
	private static readonly IntPtr NativeMethodInfoPtr_CreateOrderingElement_Private_OrderingElement_0;

	// Token: 0x040000B3 RID: 179
	private static readonly IntPtr NativeMethodInfoPtr_CreateGhostOrderingElement_Private_Transform_0;

	// Token: 0x040000B4 RID: 180
	private static readonly IntPtr NativeMethodInfoPtr_GetNormalDialogBoxUI_Public_DialogBoxUI_byref_Action_1_DialogBoxUI_0;

	// Token: 0x040000B5 RID: 181
	private static readonly IntPtr NativeMethodInfoPtr_GetNewEvaluationDialog_Public_EvalulationBoxUI_byref_Action_1_EvalulationBoxUI_0;

	// Token: 0x040000B6 RID: 182
	private static readonly IntPtr NativeMethodInfoPtr_GetNewThrowDeliverObject_Public_ControllableLaunchAnimation_byref_Action_1_ControllableLaunchAnimation_0;

	// Token: 0x040000B7 RID: 183
	private static readonly IntPtr NativeMethodInfoPtr_GetNewTipCoinObject_Public_GameObject_byref_Action_1_GameObject_0;

	// Token: 0x040000B8 RID: 184
	private static readonly IntPtr NativeMethodInfoPtr_GetOrderingElement_Public_OrderingElement_byref_Action_1_OrderingElement_0;

	// Token: 0x040000B9 RID: 185
	private static readonly IntPtr NativeMethodInfoPtr_GetGhostOrderingElement_Public_Transform_byref_Action_1_Transform_0;

	// Token: 0x040000BA RID: 186
	private static readonly IntPtr NativeMethodInfoPtr_InitializeAndPreload_Public_Void_0;

	// Token: 0x040000BB RID: 187
	private static readonly IntPtr NativeMethodInfoPtr_CleanupCache_Private_Static_Void_Stack_1_GameObject_0;

	// Token: 0x040000BC RID: 188
	private static readonly IntPtr NativeMethodInfoPtr_CleanupCache_Private_Static_Void_Stack_1_T_0;

	// Token: 0x040000BD RID: 189
	private static readonly IntPtr NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0;

	// Token: 0x040000BE RID: 190
	private static readonly IntPtr NativeMethodInfoPtr_GetCacheData_Private_T_Stack_1_T_Func_1_T_byref_Action_1_T_0;

	// Token: 0x040000BF RID: 191
	private static readonly IntPtr NativeMethodInfoPtr_Preload_Private_Void_PreloadCacheMethod_1_T_CachedObject_0;

	// Token: 0x040000C0 RID: 192
	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

	// Token: 0x040000C1 RID: 193
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000466 RID: 1126
	[Serializable]
	public sealed class CachedObject : ValueType
	{
		// Token: 0x06007C09 RID: 31753 RVA: 0x0023983C File Offset: 0x00237A3C
		// Note: this type is marked as 'beforefieldinit'.
		static CachedObject()
		{
			Il2CppClassPointerStore<ObjectCacheManager.CachedObject>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, "CachedObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectCacheManager.CachedObject>.NativeClassPtr);
			ObjectCacheManager.CachedObject.NativeFieldInfoPtr_objectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCacheManager.CachedObject>.NativeClassPtr, "objectParent");
			ObjectCacheManager.CachedObject.NativeFieldInfoPtr_preloadNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCacheManager.CachedObject>.NativeClassPtr, "preloadNum");
		}

		// Token: 0x06007C0A RID: 31754 RVA: 0x00042C38 File Offset: 0x00040E38
		public CachedObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06007C0B RID: 31755 RVA: 0x00042C41 File Offset: 0x00040E41
		public CachedObject() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectCacheManager.CachedObject>.NativeClassPtr))
		{
		}

		// Token: 0x17002A0B RID: 10763
		// (get) Token: 0x06007C0C RID: 31756 RVA: 0x00239890 File Offset: 0x00237A90
		// (set) Token: 0x06007C0D RID: 31757 RVA: 0x00042C53 File Offset: 0x00040E53
		public unsafe GameObject objectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.CachedObject.NativeFieldInfoPtr_objectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.CachedObject.NativeFieldInfoPtr_objectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A0C RID: 10764
		// (get) Token: 0x06007C0E RID: 31758 RVA: 0x002398C0 File Offset: 0x00237AC0
		// (set) Token: 0x06007C0F RID: 31759 RVA: 0x00042C72 File Offset: 0x00040E72
		public unsafe int preloadNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.CachedObject.NativeFieldInfoPtr_preloadNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.CachedObject.NativeFieldInfoPtr_preloadNum)) = value;
			}
		}

		// Token: 0x040051A1 RID: 20897
		private static readonly IntPtr NativeFieldInfoPtr_objectParent;

		// Token: 0x040051A2 RID: 20898
		private static readonly IntPtr NativeFieldInfoPtr_preloadNum;
	}

	// Token: 0x02000467 RID: 1127
	public sealed class PreloadCacheMethod<T> : MulticastDelegate
	{
		// Token: 0x06007C10 RID: 31760 RVA: 0x002398E8 File Offset: 0x00237AE8
		// Note: this type is marked as 'beforefieldinit'.
		static PreloadCacheMethod()
		{
			Il2CppClassPointerStore<ObjectCacheManager.PreloadCacheMethod<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, "PreloadCacheMethod`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			ObjectCacheManager.PreloadCacheMethod<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager.PreloadCacheMethod<T>>.NativeClassPtr, 100663426);
			ObjectCacheManager.PreloadCacheMethod<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_T_byref_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager.PreloadCacheMethod<T>>.NativeClassPtr, 100663427);
			ObjectCacheManager.PreloadCacheMethod<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Action_1_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager.PreloadCacheMethod<T>>.NativeClassPtr, 100663428);
			ObjectCacheManager.PreloadCacheMethod<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_T_byref_Action_1_T_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager.PreloadCacheMethod<T>>.NativeClassPtr, 100663429);
		}

		// Token: 0x06007C11 RID: 31761 RVA: 0x00239994 File Offset: 0x00237B94
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 3617, RefRangeEnd = 3623, XrefRangeStart = 3610, XrefRangeEnd = 3617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreloadCacheMethod(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectCacheManager.PreloadCacheMethod<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.PreloadCacheMethod<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C12 RID: 31762 RVA: 0x002399F0 File Offset: 0x00237BF0
		[CallerCount(0)]
		public unsafe T Invoke(out Action<T> pushCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.PreloadCacheMethod<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_T_byref_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pushCallback = ((intPtr4 == 0) ? null : new Action<T>(intPtr4));
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06007C13 RID: 31763 RVA: 0x00239A4C File Offset: 0x00237C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3623, XrefRangeEnd = 3624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(out Action<T> pushCallback, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.PreloadCacheMethod<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Action_1_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pushCallback = ((intPtr4 == 0) ? null : new Action<T>(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
		}

		// Token: 0x06007C14 RID: 31764 RVA: 0x00239AD4 File Offset: 0x00237CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3624, XrefRangeEnd = 3625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T EndInvoke(out Action<T> pushCallback, IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.PreloadCacheMethod<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_T_byref_Action_1_T_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pushCallback = ((intPtr4 == 0) ? null : new Action<T>(intPtr4));
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06007C15 RID: 31765 RVA: 0x00042C8D File Offset: 0x00040E8D
		public PreloadCacheMethod(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040051A3 RID: 20899
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040051A4 RID: 20900
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_T_byref_Action_1_T_0;

		// Token: 0x040051A5 RID: 20901
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_Action_1_T_AsyncCallback_Object_0;

		// Token: 0x040051A6 RID: 20902
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_T_byref_Action_1_T_IAsyncResult_0;
	}

	// Token: 0x02000468 RID: 1128
	[ObfuscatedName("ObjectCacheManager+<>c__DisplayClass31_0`1")]
	public sealed class __c__DisplayClass31_0<T> : Il2CppSystem.Object
	{
		// Token: 0x06007C16 RID: 31766 RVA: 0x00239B44 File Offset: 0x00237D44
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass31_0()
		{
			Il2CppClassPointerStore<ObjectCacheManager.__c__DisplayClass31_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr, "<>c__DisplayClass31_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectCacheManager.__c__DisplayClass31_0<T>>.NativeClassPtr);
			ObjectCacheManager.__c__DisplayClass31_0<T>.NativeFieldInfoPtr_pushCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCacheManager.__c__DisplayClass31_0<T>>.NativeClassPtr, "pushCallback");
			ObjectCacheManager.__c__DisplayClass31_0<T>.NativeFieldInfoPtr_newObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectCacheManager.__c__DisplayClass31_0<T>>.NativeClassPtr, "newObject");
			ObjectCacheManager.__c__DisplayClass31_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager.__c__DisplayClass31_0<T>>.NativeClassPtr, 100663430);
			ObjectCacheManager.__c__DisplayClass31_0<T>.NativeMethodInfoPtr__Preload_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectCacheManager.__c__DisplayClass31_0<T>>.NativeClassPtr, 100663431);
		}

		// Token: 0x06007C17 RID: 31767 RVA: 0x00239BFC File Offset: 0x00237DFC
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectCacheManager.__c__DisplayClass31_0<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.__c__DisplayClass31_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C18 RID: 31768 RVA: 0x00239C38 File Offset: 0x00237E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3625, XrefRangeEnd = 3626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Preload_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectCacheManager.__c__DisplayClass31_0<T>.NativeMethodInfoPtr__Preload_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C19 RID: 31769 RVA: 0x00042C96 File Offset: 0x00040E96
		public __c__DisplayClass31_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A0D RID: 10765
		// (get) Token: 0x06007C1A RID: 31770 RVA: 0x00239C6C File Offset: 0x00237E6C
		// (set) Token: 0x06007C1B RID: 31771 RVA: 0x00042C9F File Offset: 0x00040E9F
		public unsafe Action<T> pushCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.__c__DisplayClass31_0<T>.NativeFieldInfoPtr_pushCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.__c__DisplayClass31_0<T>.NativeFieldInfoPtr_pushCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A0E RID: 10766
		// (get) Token: 0x06007C1C RID: 31772 RVA: 0x00239C9C File Offset: 0x00237E9C
		// (set) Token: 0x06007C1D RID: 31773 RVA: 0x00239CC4 File Offset: 0x00237EC4
		public unsafe T newObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.__c__DisplayClass31_0<T>.NativeFieldInfoPtr_newObject);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectCacheManager.__c__DisplayClass31_0<T>.NativeFieldInfoPtr_newObject);
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

		// Token: 0x040051A7 RID: 20903
		private static readonly IntPtr NativeFieldInfoPtr_pushCallback;

		// Token: 0x040051A8 RID: 20904
		private static readonly IntPtr NativeFieldInfoPtr_newObject;

		// Token: 0x040051A9 RID: 20905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040051AA RID: 20906
		private static readonly IntPtr NativeMethodInfoPtr__Preload_b__0_Internal_Void_0;
	}

	// Token: 0x02000469 RID: 1129
	private sealed class MethodInfoStoreGeneric_CleanupCache_Private_Static_Void_Stack_1_T_0<T>
	{
		// Token: 0x040051AB RID: 20907
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ObjectCacheManager.NativeMethodInfoPtr_CleanupCache_Private_Static_Void_Stack_1_T_0, Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		}))));
	}

	// Token: 0x0200046A RID: 1130
	private sealed class MethodInfoStoreGeneric_GetCacheData_Private_T_Stack_1_T_Func_1_T_byref_Action_1_T_0<T>
	{
		// Token: 0x040051AC RID: 20908
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ObjectCacheManager.NativeMethodInfoPtr_GetCacheData_Private_T_Stack_1_T_Func_1_T_byref_Action_1_T_0, Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		}))));
	}

	// Token: 0x0200046B RID: 1131
	private sealed class MethodInfoStoreGeneric_Preload_Private_Void_PreloadCacheMethod_1_T_CachedObject_0<T>
	{
		// Token: 0x040051AD RID: 20909
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ObjectCacheManager.NativeMethodInfoPtr_Preload_Private_Void_PreloadCacheMethod_1_T_CachedObject_0, Il2CppClassPointerStore<ObjectCacheManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		}))));
	}
}
