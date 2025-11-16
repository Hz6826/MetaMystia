using System;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace NightScene.UI
{
	// Token: 0x020001B6 RID: 438
	public class TipAndMoneyDisplayerController : MonoBehaviour
	{
		// Token: 0x060035DC RID: 13788 RVA: 0x00157B44 File Offset: 0x00155D44
		// Note: this type is marked as 'beforefieldinit'.
		static TipAndMoneyDisplayerController()
		{
			Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI", "TipAndMoneyDisplayerController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr);
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_orderMoneyMessageParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "orderMoneyMessageParent");
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_tipMessageParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "tipMessageParent");
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_expMessageParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "expMessageParent");
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_recievedMessagePositionIndicatorParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "recievedMessagePositionIndicatorParent");
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_recievedTipPositionIndicatorParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "recievedTipPositionIndicatorParent");
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_recievedObjectField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "recievedObjectField");
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_recievedObjectLayoutField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "recievedObjectLayoutField");
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_messageStayDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "messageStayDuration");
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_messageInsertionAdjustmentDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "messageInsertionAdjustmentDuration");
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_normalEvalSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "normalEvalSprite");
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_goodEvalSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "goodEvalSprite");
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_exgoodEvalSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "exgoodEvalSprite");
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_cachedSpriteMessageCountInstences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "cachedSpriteMessageCountInstences");
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_cachedSpriteMessageInstences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "cachedSpriteMessageInstences");
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_cachedTextMessageInstences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "cachedTextMessageInstences");
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_executionQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "executionQueue");
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_interruptionCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "interruptionCollection");
			TipAndMoneyDisplayerController.NativeFieldInfoPtr_registeredObjectCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "registeredObjectCollection");
			TipAndMoneyDisplayerController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, 100673529);
			TipAndMoneyDisplayerController.NativeMethodInfoPtr_NotifyOrderMoneyMessage_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, 100673530);
			TipAndMoneyDisplayerController.NativeMethodInfoPtr_NotifyTipMessage_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, 100673531);
			TipAndMoneyDisplayerController.NativeMethodInfoPtr_NotifyExpMessage_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, 100673532);
			TipAndMoneyDisplayerController.NativeMethodInfoPtr_GetOrderMoneyMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, 100673533);
			TipAndMoneyDisplayerController.NativeMethodInfoPtr_GetTipMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, 100673534);
			TipAndMoneyDisplayerController.NativeMethodInfoPtr_GetExpMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, 100673535);
			TipAndMoneyDisplayerController.NativeMethodInfoPtr_GetInstanceInternal_Private_ValueTuple_2_UIElementCluster_GameObject_Stack_1_ValueTuple_2_UIElementCluster_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, 100673536);
			TipAndMoneyDisplayerController.NativeMethodInfoPtr_GetTipInstance_Private_ValueTuple_2_UIElementCluster_GameObject_Stack_1_ValueTuple_2_UIElementCluster_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, 100673537);
			TipAndMoneyDisplayerController.NativeMethodInfoPtr_TryExecuteNotify_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, 100673538);
			TipAndMoneyDisplayerController.NativeMethodInfoPtr_NotifyDataInternal_Private_Void_Func_1_ValueTuple_2_UIElementCluster_GameObject_Stack_1_ValueTuple_2_UIElementCluster_GameObject_Action_1_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, 100673539);
			TipAndMoneyDisplayerController.NativeMethodInfoPtr_UpdateRegisteredMessagePosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, 100673540);
			TipAndMoneyDisplayerController.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, 100673541);
			TipAndMoneyDisplayerController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, 100673542);
			TipAndMoneyDisplayerController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, 100673543);
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x00157E08 File Offset: 0x00156008
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x00157E3C File Offset: 0x0015603C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126853, RefRangeEnd = 126854, XrefRangeStart = 126837, XrefRangeEnd = 126853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyOrderMoneyMessage(int costMoney)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref costMoney;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.NativeMethodInfoPtr_NotifyOrderMoneyMessage_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x00157E7C File Offset: 0x0015607C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126873, RefRangeEnd = 126874, XrefRangeStart = 126854, XrefRangeEnd = 126873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyTipMessage(int tipMoney, int comboBuff, int moodBuff, int extraBuff)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tipMoney;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comboBuff;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moodBuff;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extraBuff;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.NativeMethodInfoPtr_NotifyTipMessage_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x00157EE4 File Offset: 0x001560E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126890, RefRangeEnd = 126891, XrefRangeStart = 126874, XrefRangeEnd = 126890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyExpMessage(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.NativeMethodInfoPtr_NotifyExpMessage_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x00157F24 File Offset: 0x00156124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126891, XrefRangeEnd = 126892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<UIElementCluster, GameObject> GetOrderMoneyMessageInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.NativeMethodInfoPtr_GetOrderMoneyMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<UIElementCluster, GameObject>(pointer);
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x00157F5C File Offset: 0x0015615C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126892, XrefRangeEnd = 126913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<UIElementCluster, GameObject> GetTipMessageInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.NativeMethodInfoPtr_GetTipMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<UIElementCluster, GameObject>(pointer);
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x00157F94 File Offset: 0x00156194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126913, XrefRangeEnd = 126914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<UIElementCluster, GameObject> GetExpMessageInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.NativeMethodInfoPtr_GetExpMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<UIElementCluster, GameObject>(pointer);
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x00157FCC File Offset: 0x001561CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126930, RefRangeEnd = 126932, XrefRangeStart = 126914, XrefRangeEnd = 126930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<UIElementCluster, GameObject> GetInstanceInternal(Stack<ValueTuple<UIElementCluster, GameObject>> collection, GameObject parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.NativeMethodInfoPtr_GetInstanceInternal_Private_ValueTuple_2_UIElementCluster_GameObject_Stack_1_ValueTuple_2_UIElementCluster_GameObject_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<UIElementCluster, GameObject>(pointer);
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x00158028 File Offset: 0x00156228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126932, XrefRangeEnd = 126948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<UIElementCluster, GameObject> GetTipInstance(Stack<ValueTuple<UIElementCluster, GameObject>> collection, GameObject parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.NativeMethodInfoPtr_GetTipInstance_Private_ValueTuple_2_UIElementCluster_GameObject_Stack_1_ValueTuple_2_UIElementCluster_GameObject_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<UIElementCluster, GameObject>(pointer);
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x00158084 File Offset: 0x00156284
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 126953, RefRangeEnd = 126956, XrefRangeStart = 126948, XrefRangeEnd = 126953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryExecuteNotify()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.NativeMethodInfoPtr_TryExecuteNotify_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x001580B8 File Offset: 0x001562B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 126974, RefRangeEnd = 126977, XrefRangeStart = 126956, XrefRangeEnd = 126974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyDataInternal(Func<ValueTuple<UIElementCluster, GameObject>> objectGenerator, Stack<ValueTuple<UIElementCluster, GameObject>> cachedObjectPool, Action<UIElementCluster> dataProcessor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectGenerator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachedObjectPool);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataProcessor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.NativeMethodInfoPtr_NotifyDataInternal_Private_Void_Func_1_ValueTuple_2_UIElementCluster_GameObject_Stack_1_ValueTuple_2_UIElementCluster_GameObject_Action_1_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E8 RID: 13800 RVA: 0x00158120 File Offset: 0x00156320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127027, RefRangeEnd = 127028, XrefRangeStart = 126977, XrefRangeEnd = 127027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRegisteredMessagePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.NativeMethodInfoPtr_UpdateRegisteredMessagePosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E9 RID: 13801 RVA: 0x00158154 File Offset: 0x00156354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127028, XrefRangeEnd = 127048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x00158188 File Offset: 0x00156388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127048, XrefRangeEnd = 127074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TipAndMoneyDisplayerController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x001581C4 File Offset: 0x001563C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127074, XrefRangeEnd = 127114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TipAndMoneyDisplayerController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x0001DE88 File Offset: 0x0001C088
		public TipAndMoneyDisplayerController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x060035ED RID: 13805 RVA: 0x00158200 File Offset: 0x00156400
		// (set) Token: 0x060035EE RID: 13806 RVA: 0x0001DE91 File Offset: 0x0001C091
		public unsafe GameObject orderMoneyMessageParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_orderMoneyMessageParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_orderMoneyMessageParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x060035EF RID: 13807 RVA: 0x00158230 File Offset: 0x00156430
		// (set) Token: 0x060035F0 RID: 13808 RVA: 0x0001DEB0 File Offset: 0x0001C0B0
		public unsafe GameObject tipMessageParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_tipMessageParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_tipMessageParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x060035F1 RID: 13809 RVA: 0x00158260 File Offset: 0x00156460
		// (set) Token: 0x060035F2 RID: 13810 RVA: 0x0001DECF File Offset: 0x0001C0CF
		public unsafe GameObject expMessageParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_expMessageParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_expMessageParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x060035F3 RID: 13811 RVA: 0x00158290 File Offset: 0x00156490
		// (set) Token: 0x060035F4 RID: 13812 RVA: 0x0001DEEE File Offset: 0x0001C0EE
		public unsafe GameObject recievedMessagePositionIndicatorParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_recievedMessagePositionIndicatorParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_recievedMessagePositionIndicatorParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x060035F5 RID: 13813 RVA: 0x001582C0 File Offset: 0x001564C0
		// (set) Token: 0x060035F6 RID: 13814 RVA: 0x0001DF0D File Offset: 0x0001C10D
		public unsafe GameObject recievedTipPositionIndicatorParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_recievedTipPositionIndicatorParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_recievedTipPositionIndicatorParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x060035F7 RID: 13815 RVA: 0x001582F0 File Offset: 0x001564F0
		// (set) Token: 0x060035F8 RID: 13816 RVA: 0x0001DF2C File Offset: 0x0001C12C
		public unsafe RectTransform recievedObjectField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_recievedObjectField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_recievedObjectField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x060035F9 RID: 13817 RVA: 0x00158320 File Offset: 0x00156520
		// (set) Token: 0x060035FA RID: 13818 RVA: 0x0001DF4B File Offset: 0x0001C14B
		public unsafe RectTransform recievedObjectLayoutField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_recievedObjectLayoutField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_recievedObjectLayoutField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x060035FB RID: 13819 RVA: 0x00158350 File Offset: 0x00156550
		// (set) Token: 0x060035FC RID: 13820 RVA: 0x0001DF6A File Offset: 0x0001C16A
		public unsafe float messageStayDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_messageStayDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_messageStayDuration)) = value;
			}
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x060035FD RID: 13821 RVA: 0x00158378 File Offset: 0x00156578
		// (set) Token: 0x060035FE RID: 13822 RVA: 0x0001DF85 File Offset: 0x0001C185
		public unsafe float messageInsertionAdjustmentDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_messageInsertionAdjustmentDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_messageInsertionAdjustmentDuration)) = value;
			}
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x060035FF RID: 13823 RVA: 0x001583A0 File Offset: 0x001565A0
		// (set) Token: 0x06003600 RID: 13824 RVA: 0x0001DFA0 File Offset: 0x0001C1A0
		public unsafe Sprite normalEvalSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_normalEvalSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_normalEvalSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x06003601 RID: 13825 RVA: 0x001583D0 File Offset: 0x001565D0
		// (set) Token: 0x06003602 RID: 13826 RVA: 0x0001DFBF File Offset: 0x0001C1BF
		public unsafe Sprite goodEvalSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_goodEvalSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_goodEvalSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x06003603 RID: 13827 RVA: 0x00158400 File Offset: 0x00156600
		// (set) Token: 0x06003604 RID: 13828 RVA: 0x0001DFDE File Offset: 0x0001C1DE
		public unsafe Sprite exgoodEvalSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_exgoodEvalSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_exgoodEvalSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x06003605 RID: 13829 RVA: 0x00158430 File Offset: 0x00156630
		// (set) Token: 0x06003606 RID: 13830 RVA: 0x0001DFFD File Offset: 0x0001C1FD
		public unsafe Stack<ValueTuple<UIElementCluster, GameObject>> cachedSpriteMessageCountInstences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_cachedSpriteMessageCountInstences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ValueTuple<UIElementCluster, GameObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_cachedSpriteMessageCountInstences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x06003607 RID: 13831 RVA: 0x00158460 File Offset: 0x00156660
		// (set) Token: 0x06003608 RID: 13832 RVA: 0x0001E01C File Offset: 0x0001C21C
		public unsafe Stack<ValueTuple<UIElementCluster, GameObject>> cachedSpriteMessageInstences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_cachedSpriteMessageInstences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ValueTuple<UIElementCluster, GameObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_cachedSpriteMessageInstences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x06003609 RID: 13833 RVA: 0x00158490 File Offset: 0x00156690
		// (set) Token: 0x0600360A RID: 13834 RVA: 0x0001E03B File Offset: 0x0001C23B
		public unsafe Stack<ValueTuple<UIElementCluster, GameObject>> cachedTextMessageInstences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_cachedTextMessageInstences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ValueTuple<UIElementCluster, GameObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_cachedTextMessageInstences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x0600360B RID: 13835 RVA: 0x001584C0 File Offset: 0x001566C0
		// (set) Token: 0x0600360C RID: 13836 RVA: 0x0001E05A File Offset: 0x0001C25A
		public unsafe Queue<Action> executionQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_executionQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_executionQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x0600360D RID: 13837 RVA: 0x001584F0 File Offset: 0x001566F0
		// (set) Token: 0x0600360E RID: 13838 RVA: 0x0001E079 File Offset: 0x0001C279
		public unsafe HashSet<Action> interruptionCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_interruptionCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_interruptionCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x0600360F RID: 13839 RVA: 0x00158520 File Offset: 0x00156720
		// (set) Token: 0x06003610 RID: 13840 RVA: 0x0001E098 File Offset: 0x0001C298
		public unsafe HashSet<ValueTuple<UIElementCluster, GameObject>> registeredObjectCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_registeredObjectCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ValueTuple<UIElementCluster, GameObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.NativeFieldInfoPtr_registeredObjectCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002466 RID: 9318
		private static readonly IntPtr NativeFieldInfoPtr_orderMoneyMessageParent;

		// Token: 0x04002467 RID: 9319
		private static readonly IntPtr NativeFieldInfoPtr_tipMessageParent;

		// Token: 0x04002468 RID: 9320
		private static readonly IntPtr NativeFieldInfoPtr_expMessageParent;

		// Token: 0x04002469 RID: 9321
		private static readonly IntPtr NativeFieldInfoPtr_recievedMessagePositionIndicatorParent;

		// Token: 0x0400246A RID: 9322
		private static readonly IntPtr NativeFieldInfoPtr_recievedTipPositionIndicatorParent;

		// Token: 0x0400246B RID: 9323
		private static readonly IntPtr NativeFieldInfoPtr_recievedObjectField;

		// Token: 0x0400246C RID: 9324
		private static readonly IntPtr NativeFieldInfoPtr_recievedObjectLayoutField;

		// Token: 0x0400246D RID: 9325
		private static readonly IntPtr NativeFieldInfoPtr_messageStayDuration;

		// Token: 0x0400246E RID: 9326
		private static readonly IntPtr NativeFieldInfoPtr_messageInsertionAdjustmentDuration;

		// Token: 0x0400246F RID: 9327
		private static readonly IntPtr NativeFieldInfoPtr_normalEvalSprite;

		// Token: 0x04002470 RID: 9328
		private static readonly IntPtr NativeFieldInfoPtr_goodEvalSprite;

		// Token: 0x04002471 RID: 9329
		private static readonly IntPtr NativeFieldInfoPtr_exgoodEvalSprite;

		// Token: 0x04002472 RID: 9330
		private static readonly IntPtr NativeFieldInfoPtr_cachedSpriteMessageCountInstences;

		// Token: 0x04002473 RID: 9331
		private static readonly IntPtr NativeFieldInfoPtr_cachedSpriteMessageInstences;

		// Token: 0x04002474 RID: 9332
		private static readonly IntPtr NativeFieldInfoPtr_cachedTextMessageInstences;

		// Token: 0x04002475 RID: 9333
		private static readonly IntPtr NativeFieldInfoPtr_executionQueue;

		// Token: 0x04002476 RID: 9334
		private static readonly IntPtr NativeFieldInfoPtr_interruptionCollection;

		// Token: 0x04002477 RID: 9335
		private static readonly IntPtr NativeFieldInfoPtr_registeredObjectCollection;

		// Token: 0x04002478 RID: 9336
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002479 RID: 9337
		private static readonly IntPtr NativeMethodInfoPtr_NotifyOrderMoneyMessage_Public_Void_Int32_0;

		// Token: 0x0400247A RID: 9338
		private static readonly IntPtr NativeMethodInfoPtr_NotifyTipMessage_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400247B RID: 9339
		private static readonly IntPtr NativeMethodInfoPtr_NotifyExpMessage_Public_Void_Int32_0;

		// Token: 0x0400247C RID: 9340
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderMoneyMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0;

		// Token: 0x0400247D RID: 9341
		private static readonly IntPtr NativeMethodInfoPtr_GetTipMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0;

		// Token: 0x0400247E RID: 9342
		private static readonly IntPtr NativeMethodInfoPtr_GetExpMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0;

		// Token: 0x0400247F RID: 9343
		private static readonly IntPtr NativeMethodInfoPtr_GetInstanceInternal_Private_ValueTuple_2_UIElementCluster_GameObject_Stack_1_ValueTuple_2_UIElementCluster_GameObject_GameObject_0;

		// Token: 0x04002480 RID: 9344
		private static readonly IntPtr NativeMethodInfoPtr_GetTipInstance_Private_ValueTuple_2_UIElementCluster_GameObject_Stack_1_ValueTuple_2_UIElementCluster_GameObject_GameObject_0;

		// Token: 0x04002481 RID: 9345
		private static readonly IntPtr NativeMethodInfoPtr_TryExecuteNotify_Private_Void_0;

		// Token: 0x04002482 RID: 9346
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDataInternal_Private_Void_Func_1_ValueTuple_2_UIElementCluster_GameObject_Stack_1_ValueTuple_2_UIElementCluster_GameObject_Action_1_UIElementCluster_0;

		// Token: 0x04002483 RID: 9347
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRegisteredMessagePosition_Private_Void_0;

		// Token: 0x04002484 RID: 9348
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04002485 RID: 9349
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04002486 RID: 9350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000912 RID: 2322
		[ObfuscatedName("NightScene.UI.TipAndMoneyDisplayerController+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B74F RID: 46927 RVA: 0x002E7404 File Offset: 0x002E5604
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass19_0>.NativeClassPtr);
				TipAndMoneyDisplayerController.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass19_0>.NativeClassPtr, "<>4__this");
				TipAndMoneyDisplayerController.__c__DisplayClass19_0.NativeFieldInfoPtr_costMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass19_0>.NativeClassPtr, "costMoney");
				TipAndMoneyDisplayerController.__c__DisplayClass19_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass19_0>.NativeClassPtr, "<>9__1");
				TipAndMoneyDisplayerController.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass19_0>.NativeClassPtr, 100673544);
				TipAndMoneyDisplayerController.__c__DisplayClass19_0.NativeMethodInfoPtr__NotifyOrderMoneyMessage_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass19_0>.NativeClassPtr, 100673545);
				TipAndMoneyDisplayerController.__c__DisplayClass19_0.NativeMethodInfoPtr__NotifyOrderMoneyMessage_b__1_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass19_0>.NativeClassPtr, 100673546);
			}

			// Token: 0x0600B750 RID: 46928 RVA: 0x002E74A8 File Offset: 0x002E56A8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B751 RID: 46929 RVA: 0x002E74E4 File Offset: 0x002E56E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126676, XrefRangeEnd = 126690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifyOrderMoneyMessage_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass19_0.NativeMethodInfoPtr__NotifyOrderMoneyMessage_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B752 RID: 46930 RVA: 0x002E7518 File Offset: 0x002E5718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126690, XrefRangeEnd = 126698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifyOrderMoneyMessage_b__1(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass19_0.NativeMethodInfoPtr__NotifyOrderMoneyMessage_b__1_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B753 RID: 46931 RVA: 0x00062DB7 File Offset: 0x00060FB7
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C19 RID: 15385
			// (get) Token: 0x0600B754 RID: 46932 RVA: 0x002E755C File Offset: 0x002E575C
			// (set) Token: 0x0600B755 RID: 46933 RVA: 0x00062DC0 File Offset: 0x00060FC0
			public unsafe TipAndMoneyDisplayerController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TipAndMoneyDisplayerController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C1A RID: 15386
			// (get) Token: 0x0600B756 RID: 46934 RVA: 0x002E758C File Offset: 0x002E578C
			// (set) Token: 0x0600B757 RID: 46935 RVA: 0x00062DDF File Offset: 0x00060FDF
			public unsafe int costMoney
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass19_0.NativeFieldInfoPtr_costMoney);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass19_0.NativeFieldInfoPtr_costMoney)) = value;
				}
			}

			// Token: 0x17003C1B RID: 15387
			// (get) Token: 0x0600B758 RID: 46936 RVA: 0x002E75B4 File Offset: 0x002E57B4
			// (set) Token: 0x0600B759 RID: 46937 RVA: 0x00062DFA File Offset: 0x00060FFA
			public unsafe Action<UIElementCluster> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass19_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass19_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040076A9 RID: 30377
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040076AA RID: 30378
			private static readonly IntPtr NativeFieldInfoPtr_costMoney;

			// Token: 0x040076AB RID: 30379
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040076AC RID: 30380
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040076AD RID: 30381
			private static readonly IntPtr NativeMethodInfoPtr__NotifyOrderMoneyMessage_b__0_Internal_Void_0;

			// Token: 0x040076AE RID: 30382
			private static readonly IntPtr NativeMethodInfoPtr__NotifyOrderMoneyMessage_b__1_Internal_Void_UIElementCluster_0;
		}

		// Token: 0x02000913 RID: 2323
		[ObfuscatedName("NightScene.UI.TipAndMoneyDisplayerController+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B75A RID: 46938 RVA: 0x002E75E4 File Offset: 0x002E57E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass20_0>.NativeClassPtr);
				TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr_tipMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass20_0>.NativeClassPtr, "tipMoney");
				TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr_comboBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass20_0>.NativeClassPtr, "comboBuff");
				TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr_moodBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass20_0>.NativeClassPtr, "moodBuff");
				TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr_extraBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass20_0>.NativeClassPtr, "extraBuff");
				TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr_moodImageSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass20_0>.NativeClassPtr, "moodImageSprite");
				TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass20_0>.NativeClassPtr, "<>9__1");
				TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass20_0>.NativeClassPtr, 100673547);
				TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeMethodInfoPtr__NotifyTipMessage_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass20_0>.NativeClassPtr, 100673548);
				TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeMethodInfoPtr__NotifyTipMessage_b__1_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass20_0>.NativeClassPtr, 100673549);
			}

			// Token: 0x0600B75B RID: 46939 RVA: 0x002E76D8 File Offset: 0x002E58D8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B75C RID: 46940 RVA: 0x002E7714 File Offset: 0x002E5914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126698, XrefRangeEnd = 126712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifyTipMessage_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeMethodInfoPtr__NotifyTipMessage_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B75D RID: 46941 RVA: 0x002E7748 File Offset: 0x002E5948
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126712, XrefRangeEnd = 126740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifyTipMessage_b__1(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeMethodInfoPtr__NotifyTipMessage_b__1_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B75E RID: 46942 RVA: 0x00062E19 File Offset: 0x00061019
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C1C RID: 15388
			// (get) Token: 0x0600B75F RID: 46943 RVA: 0x002E778C File Offset: 0x002E598C
			// (set) Token: 0x0600B760 RID: 46944 RVA: 0x00062E22 File Offset: 0x00061022
			public unsafe TipAndMoneyDisplayerController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TipAndMoneyDisplayerController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C1D RID: 15389
			// (get) Token: 0x0600B761 RID: 46945 RVA: 0x002E77BC File Offset: 0x002E59BC
			// (set) Token: 0x0600B762 RID: 46946 RVA: 0x00062E41 File Offset: 0x00061041
			public unsafe int tipMoney
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr_tipMoney);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr_tipMoney)) = value;
				}
			}

			// Token: 0x17003C1E RID: 15390
			// (get) Token: 0x0600B763 RID: 46947 RVA: 0x002E77E4 File Offset: 0x002E59E4
			// (set) Token: 0x0600B764 RID: 46948 RVA: 0x00062E5C File Offset: 0x0006105C
			public unsafe int comboBuff
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr_comboBuff);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr_comboBuff)) = value;
				}
			}

			// Token: 0x17003C1F RID: 15391
			// (get) Token: 0x0600B765 RID: 46949 RVA: 0x002E780C File Offset: 0x002E5A0C
			// (set) Token: 0x0600B766 RID: 46950 RVA: 0x00062E77 File Offset: 0x00061077
			public unsafe int moodBuff
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr_moodBuff);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr_moodBuff)) = value;
				}
			}

			// Token: 0x17003C20 RID: 15392
			// (get) Token: 0x0600B767 RID: 46951 RVA: 0x002E7834 File Offset: 0x002E5A34
			// (set) Token: 0x0600B768 RID: 46952 RVA: 0x00062E92 File Offset: 0x00061092
			public unsafe int extraBuff
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr_extraBuff);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr_extraBuff)) = value;
				}
			}

			// Token: 0x17003C21 RID: 15393
			// (get) Token: 0x0600B769 RID: 46953 RVA: 0x002E785C File Offset: 0x002E5A5C
			// (set) Token: 0x0600B76A RID: 46954 RVA: 0x00062EAD File Offset: 0x000610AD
			public unsafe Sprite moodImageSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr_moodImageSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr_moodImageSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C22 RID: 15394
			// (get) Token: 0x0600B76B RID: 46955 RVA: 0x002E788C File Offset: 0x002E5A8C
			// (set) Token: 0x0600B76C RID: 46956 RVA: 0x00062ECC File Offset: 0x000610CC
			public unsafe Action<UIElementCluster> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass20_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040076AF RID: 30383
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040076B0 RID: 30384
			private static readonly IntPtr NativeFieldInfoPtr_tipMoney;

			// Token: 0x040076B1 RID: 30385
			private static readonly IntPtr NativeFieldInfoPtr_comboBuff;

			// Token: 0x040076B2 RID: 30386
			private static readonly IntPtr NativeFieldInfoPtr_moodBuff;

			// Token: 0x040076B3 RID: 30387
			private static readonly IntPtr NativeFieldInfoPtr_extraBuff;

			// Token: 0x040076B4 RID: 30388
			private static readonly IntPtr NativeFieldInfoPtr_moodImageSprite;

			// Token: 0x040076B5 RID: 30389
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040076B6 RID: 30390
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040076B7 RID: 30391
			private static readonly IntPtr NativeMethodInfoPtr__NotifyTipMessage_b__0_Internal_Void_0;

			// Token: 0x040076B8 RID: 30392
			private static readonly IntPtr NativeMethodInfoPtr__NotifyTipMessage_b__1_Internal_Void_UIElementCluster_0;
		}

		// Token: 0x02000914 RID: 2324
		[ObfuscatedName("NightScene.UI.TipAndMoneyDisplayerController+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B76D RID: 46957 RVA: 0x002E78BC File Offset: 0x002E5ABC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass21_0>.NativeClassPtr);
				TipAndMoneyDisplayerController.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				TipAndMoneyDisplayerController.__c__DisplayClass21_0.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass21_0>.NativeClassPtr, "count");
				TipAndMoneyDisplayerController.__c__DisplayClass21_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass21_0>.NativeClassPtr, "<>9__1");
				TipAndMoneyDisplayerController.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass21_0>.NativeClassPtr, 100673550);
				TipAndMoneyDisplayerController.__c__DisplayClass21_0.NativeMethodInfoPtr__NotifyExpMessage_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass21_0>.NativeClassPtr, 100673551);
				TipAndMoneyDisplayerController.__c__DisplayClass21_0.NativeMethodInfoPtr__NotifyExpMessage_b__1_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass21_0>.NativeClassPtr, 100673552);
			}

			// Token: 0x0600B76E RID: 46958 RVA: 0x002E7960 File Offset: 0x002E5B60
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B76F RID: 46959 RVA: 0x002E799C File Offset: 0x002E5B9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126740, XrefRangeEnd = 126754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifyExpMessage_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass21_0.NativeMethodInfoPtr__NotifyExpMessage_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B770 RID: 46960 RVA: 0x002E79D0 File Offset: 0x002E5BD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126754, XrefRangeEnd = 126762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifyExpMessage_b__1(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass21_0.NativeMethodInfoPtr__NotifyExpMessage_b__1_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B771 RID: 46961 RVA: 0x00062EEB File Offset: 0x000610EB
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C23 RID: 15395
			// (get) Token: 0x0600B772 RID: 46962 RVA: 0x002E7A14 File Offset: 0x002E5C14
			// (set) Token: 0x0600B773 RID: 46963 RVA: 0x00062EF4 File Offset: 0x000610F4
			public unsafe TipAndMoneyDisplayerController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TipAndMoneyDisplayerController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C24 RID: 15396
			// (get) Token: 0x0600B774 RID: 46964 RVA: 0x002E7A44 File Offset: 0x002E5C44
			// (set) Token: 0x0600B775 RID: 46965 RVA: 0x00062F13 File Offset: 0x00061113
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass21_0.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass21_0.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x17003C25 RID: 15397
			// (get) Token: 0x0600B776 RID: 46966 RVA: 0x002E7A6C File Offset: 0x002E5C6C
			// (set) Token: 0x0600B777 RID: 46967 RVA: 0x00062F2E File Offset: 0x0006112E
			public unsafe Action<UIElementCluster> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass21_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass21_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040076B9 RID: 30393
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040076BA RID: 30394
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x040076BB RID: 30395
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040076BC RID: 30396
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040076BD RID: 30397
			private static readonly IntPtr NativeMethodInfoPtr__NotifyExpMessage_b__0_Internal_Void_0;

			// Token: 0x040076BE RID: 30398
			private static readonly IntPtr NativeMethodInfoPtr__NotifyExpMessage_b__1_Internal_Void_UIElementCluster_0;
		}

		// Token: 0x02000915 RID: 2325
		[ObfuscatedName("NightScene.UI.TipAndMoneyDisplayerController+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B778 RID: 46968 RVA: 0x002E7A9C File Offset: 0x002E5C9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0>.NativeClassPtr);
				TipAndMoneyDisplayerController.__c__DisplayClass28_0.NativeFieldInfoPtr_cachedObjectPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0>.NativeClassPtr, "cachedObjectPool");
				TipAndMoneyDisplayerController.__c__DisplayClass28_0.NativeFieldInfoPtr_objectInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0>.NativeClassPtr, "objectInstance");
				TipAndMoneyDisplayerController.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
				TipAndMoneyDisplayerController.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0>.NativeClassPtr, 100673553);
				TipAndMoneyDisplayerController.__c__DisplayClass28_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0>.NativeClassPtr, 100673554);
			}

			// Token: 0x0600B779 RID: 46969 RVA: 0x002E7B2C File Offset: 0x002E5D2C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B77A RID: 46970 RVA: 0x002E7B68 File Offset: 0x002E5D68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126792, XrefRangeEnd = 126797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass28_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600B77B RID: 46971 RVA: 0x00062F4D File Offset: 0x0006114D
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C26 RID: 15398
			// (get) Token: 0x0600B77C RID: 46972 RVA: 0x002E7BA8 File Offset: 0x002E5DA8
			// (set) Token: 0x0600B77D RID: 46973 RVA: 0x00062F56 File Offset: 0x00061156
			public unsafe Stack<ValueTuple<UIElementCluster, GameObject>> cachedObjectPool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass28_0.NativeFieldInfoPtr_cachedObjectPool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ValueTuple<UIElementCluster, GameObject>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass28_0.NativeFieldInfoPtr_cachedObjectPool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C27 RID: 15399
			// (get) Token: 0x0600B77E RID: 46974 RVA: 0x002E7BD8 File Offset: 0x002E5DD8
			// (set) Token: 0x0600B77F RID: 46975 RVA: 0x00062F75 File Offset: 0x00061175
			public ValueTuple<UIElementCluster, GameObject> objectInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass28_0.NativeFieldInfoPtr_objectInstance);
					return new ValueTuple<UIElementCluster, GameObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<UIElementCluster, GameObject>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass28_0.NativeFieldInfoPtr_objectInstance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<UIElementCluster, GameObject>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003C28 RID: 15400
			// (get) Token: 0x0600B780 RID: 46976 RVA: 0x002E7C08 File Offset: 0x002E5E08
			// (set) Token: 0x0600B781 RID: 46977 RVA: 0x00062FA3 File Offset: 0x000611A3
			public unsafe TipAndMoneyDisplayerController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TipAndMoneyDisplayerController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040076BF RID: 30399
			private static readonly IntPtr NativeFieldInfoPtr_cachedObjectPool;

			// Token: 0x040076C0 RID: 30400
			private static readonly IntPtr NativeFieldInfoPtr_objectInstance;

			// Token: 0x040076C1 RID: 30401
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040076C2 RID: 30402
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040076C3 RID: 30403
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000FF8 RID: 4088
			[ObfuscatedName("NightScene.UI.TipAndMoneyDisplayerController+<>c__DisplayClass28_0+<<NotifyDataInternal>g__OnRegisteredMessageTiming|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011847 RID: 71751 RVA: 0x004059A8 File Offset: 0x00403BA8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique()
				{
					Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0>.NativeClassPtr, "<<NotifyDataInternal>g__OnRegisteredMessageTiming|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique>.NativeClassPtr);
					TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique>.NativeClassPtr, "<>1__state");
					TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique>.NativeClassPtr, "<>2__current");
					TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique>.NativeClassPtr, "<>4__this");
					TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeFieldInfoPtr__thisObjectInstance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique>.NativeClassPtr, "<thisObjectInstance>5__2");
					TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique>.NativeClassPtr, 100673555);
					TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique>.NativeClassPtr, 100673556);
					TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique>.NativeClassPtr, 100673557);
					TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique>.NativeClassPtr, 100673558);
					TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique>.NativeClassPtr, 100673559);
					TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique>.NativeClassPtr, 100673560);
				}

				// Token: 0x06011848 RID: 71752 RVA: 0x00405A9C File Offset: 0x00403C9C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011849 RID: 71753 RVA: 0x00405AE4 File Offset: 0x00403CE4
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601184A RID: 71754 RVA: 0x00405B18 File Offset: 0x00403D18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126762, XrefRangeEnd = 126786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005B1D RID: 23325
				// (get) Token: 0x0601184B RID: 71755 RVA: 0x00405B54 File Offset: 0x00403D54
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601184C RID: 71756 RVA: 0x00405B94 File Offset: 0x00403D94
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126786, XrefRangeEnd = 126792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005B1E RID: 23326
				// (get) Token: 0x0601184D RID: 71757 RVA: 0x00405BC8 File Offset: 0x00403DC8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601184E RID: 71758 RVA: 0x000985F5 File Offset: 0x000967F5
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B19 RID: 23321
				// (get) Token: 0x0601184F RID: 71759 RVA: 0x00405C08 File Offset: 0x00403E08
				// (set) Token: 0x06011850 RID: 71760 RVA: 0x000985FE File Offset: 0x000967FE
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005B1A RID: 23322
				// (get) Token: 0x06011851 RID: 71761 RVA: 0x00405C30 File Offset: 0x00403E30
				// (set) Token: 0x06011852 RID: 71762 RVA: 0x00098619 File Offset: 0x00096819
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B1B RID: 23323
				// (get) Token: 0x06011853 RID: 71763 RVA: 0x00405C60 File Offset: 0x00403E60
				// (set) Token: 0x06011854 RID: 71764 RVA: 0x00098638 File Offset: 0x00096838
				public unsafe TipAndMoneyDisplayerController.__c__DisplayClass28_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<TipAndMoneyDisplayerController.__c__DisplayClass28_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B1C RID: 23324
				// (get) Token: 0x06011855 RID: 71765 RVA: 0x00405C90 File Offset: 0x00403E90
				// (set) Token: 0x06011856 RID: 71766 RVA: 0x00098657 File Offset: 0x00096857
				public ValueTuple<UIElementCluster, GameObject> _thisObjectInstance_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeFieldInfoPtr__thisObjectInstance_5__2);
						return new ValueTuple<UIElementCluster, GameObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<UIElementCluster, GameObject>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass28_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaObObUnique.NativeFieldInfoPtr__thisObjectInstance_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<UIElementCluster, GameObject>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400B115 RID: 45333
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B116 RID: 45334
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B117 RID: 45335
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B118 RID: 45336
				private static readonly IntPtr NativeFieldInfoPtr__thisObjectInstance_5__2;

				// Token: 0x0400B119 RID: 45337
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B11A RID: 45338
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B11B RID: 45339
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B11C RID: 45340
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B11D RID: 45341
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B11E RID: 45342
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000916 RID: 2326
		[ObfuscatedName("NightScene.UI.TipAndMoneyDisplayerController+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B782 RID: 46978 RVA: 0x002E7C38 File Offset: 0x002E5E38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass29_0>.NativeClassPtr);
				TipAndMoneyDisplayerController.__c__DisplayClass29_0.NativeFieldInfoPtr_dataPair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass29_0>.NativeClassPtr, "dataPair");
				TipAndMoneyDisplayerController.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass29_0>.NativeClassPtr, "<>4__this");
				TipAndMoneyDisplayerController.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass29_0>.NativeClassPtr, 100673561);
				TipAndMoneyDisplayerController.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass29_0>.NativeClassPtr, 100673562);
				TipAndMoneyDisplayerController.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass29_0>.NativeClassPtr, 100673563);
				TipAndMoneyDisplayerController.__c__DisplayClass29_0.NativeMethodInfoPtr__UpdateRegisteredMessagePosition_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass29_0>.NativeClassPtr, 100673564);
			}

			// Token: 0x0600B783 RID: 46979 RVA: 0x002E7CDC File Offset: 0x002E5EDC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B784 RID: 46980 RVA: 0x002E7D18 File Offset: 0x002E5F18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126797, XrefRangeEnd = 126817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Single_PDM_0(float progress)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref progress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B785 RID: 46981 RVA: 0x002E7D58 File Offset: 0x002E5F58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126817, XrefRangeEnd = 126819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B786 RID: 46982 RVA: 0x002E7D8C File Offset: 0x002E5F8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126819, XrefRangeEnd = 126829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateRegisteredMessagePosition_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c__DisplayClass29_0.NativeMethodInfoPtr__UpdateRegisteredMessagePosition_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B787 RID: 46983 RVA: 0x00062FC2 File Offset: 0x000611C2
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C29 RID: 15401
			// (get) Token: 0x0600B788 RID: 46984 RVA: 0x002E7DC0 File Offset: 0x002E5FC0
			// (set) Token: 0x0600B789 RID: 46985 RVA: 0x00062FCB File Offset: 0x000611CB
			public unsafe IEnumerable<ValueTuple<Transform, Vector3, Vector3>> dataPair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass29_0.NativeFieldInfoPtr_dataPair);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<Transform, Vector3, Vector3>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass29_0.NativeFieldInfoPtr_dataPair), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C2A RID: 15402
			// (get) Token: 0x0600B78A RID: 46986 RVA: 0x002E7DF0 File Offset: 0x002E5FF0
			// (set) Token: 0x0600B78B RID: 46987 RVA: 0x00062FEA File Offset: 0x000611EA
			public unsafe TipAndMoneyDisplayerController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TipAndMoneyDisplayerController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TipAndMoneyDisplayerController.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040076C4 RID: 30404
			private static readonly IntPtr NativeFieldInfoPtr_dataPair;

			// Token: 0x040076C5 RID: 30405
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040076C6 RID: 30406
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040076C7 RID: 30407
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0;

			// Token: 0x040076C8 RID: 30408
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x040076C9 RID: 30409
			private static readonly IntPtr NativeMethodInfoPtr__UpdateRegisteredMessagePosition_b__3_Internal_Void_0;
		}

		// Token: 0x02000917 RID: 2327
		[ObfuscatedName("NightScene.UI.TipAndMoneyDisplayerController+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600B78C RID: 46988 RVA: 0x002E7E20 File Offset: 0x002E6020
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TipAndMoneyDisplayerController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c>.NativeClassPtr);
				TipAndMoneyDisplayerController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c>.NativeClassPtr, "<>9");
				TipAndMoneyDisplayerController.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c>.NativeClassPtr, "<>9__29_0");
				TipAndMoneyDisplayerController.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c>.NativeClassPtr, "<>9__30_0");
				TipAndMoneyDisplayerController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c>.NativeClassPtr, 100673566);
				TipAndMoneyDisplayerController.__c.NativeMethodInfoPtr__UpdateRegisteredMessagePosition_b__29_0_Internal_ValueTuple_3_Transform_Vector3_Vector3_ValueTuple_2_UIElementCluster_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c>.NativeClassPtr, 100673567);
				TipAndMoneyDisplayerController.__c.NativeMethodInfoPtr__Dispose_b__30_0_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c>.NativeClassPtr, 100673568);
			}

			// Token: 0x0600B78D RID: 46989 RVA: 0x002E7EC4 File Offset: 0x002E60C4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TipAndMoneyDisplayerController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B78E RID: 46990 RVA: 0x002E7F00 File Offset: 0x002E6100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126829, XrefRangeEnd = 126837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<Transform, Vector3, Vector3> _UpdateRegisteredMessagePosition_b__29_0(ValueTuple<UIElementCluster, GameObject> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c.NativeMethodInfoPtr__UpdateRegisteredMessagePosition_b__29_0_Internal_ValueTuple_3_Transform_Vector3_Vector3_ValueTuple_2_UIElementCluster_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<Transform, Vector3, Vector3>(pointer);
			}

			// Token: 0x0600B78F RID: 46991 RVA: 0x002E7F50 File Offset: 0x002E6150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Dispose_b__30_0(Action x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TipAndMoneyDisplayerController.__c.NativeMethodInfoPtr__Dispose_b__30_0_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B790 RID: 46992 RVA: 0x00063009 File Offset: 0x00061209
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C2B RID: 15403
			// (get) Token: 0x0600B791 RID: 46993 RVA: 0x002E7F94 File Offset: 0x002E6194
			// (set) Token: 0x0600B792 RID: 46994 RVA: 0x00063012 File Offset: 0x00061212
			public unsafe static TipAndMoneyDisplayerController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TipAndMoneyDisplayerController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TipAndMoneyDisplayerController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TipAndMoneyDisplayerController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C2C RID: 15404
			// (get) Token: 0x0600B793 RID: 46995 RVA: 0x002E7FBC File Offset: 0x002E61BC
			// (set) Token: 0x0600B794 RID: 46996 RVA: 0x00063024 File Offset: 0x00061224
			public unsafe static Func<ValueTuple<UIElementCluster, GameObject>, ValueTuple<Transform, Vector3, Vector3>> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TipAndMoneyDisplayerController.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<UIElementCluster, GameObject>, ValueTuple<Transform, Vector3, Vector3>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TipAndMoneyDisplayerController.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C2D RID: 15405
			// (get) Token: 0x0600B795 RID: 46997 RVA: 0x002E7FE4 File Offset: 0x002E61E4
			// (set) Token: 0x0600B796 RID: 46998 RVA: 0x00063036 File Offset: 0x00061236
			public unsafe static Action<Action> __9__30_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TipAndMoneyDisplayerController.__c.NativeFieldInfoPtr___9__30_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TipAndMoneyDisplayerController.__c.NativeFieldInfoPtr___9__30_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040076CA RID: 30410
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040076CB RID: 30411
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x040076CC RID: 30412
			private static readonly IntPtr NativeFieldInfoPtr___9__30_0;

			// Token: 0x040076CD RID: 30413
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040076CE RID: 30414
			private static readonly IntPtr NativeMethodInfoPtr__UpdateRegisteredMessagePosition_b__29_0_Internal_ValueTuple_3_Transform_Vector3_Vector3_ValueTuple_2_UIElementCluster_GameObject_0;

			// Token: 0x040076CF RID: 30415
			private static readonly IntPtr NativeMethodInfoPtr__Dispose_b__30_0_Internal_Void_Action_0;
		}
	}
}
