using System;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Night.BossBattle.DLC4_BossBattle;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020001C5 RID: 453
	public class IncomeControllerFlandre_CardRechargeIndicator : MonoBehaviour
	{
		// Token: 0x06003879 RID: 14457 RVA: 0x0015FF08 File Offset: 0x0015E108
		// Note: this type is marked as 'beforefieldinit'.
		static IncomeControllerFlandre_CardRechargeIndicator()
		{
			Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.HUDUtility", "IncomeControllerFlandre_CardRechargeIndicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr);
			IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_SpecialCardField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, "m_SpecialCardField");
			IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_NormalCardField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, "m_NormalCardField");
			IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_BufferField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, "m_BufferField");
			IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_CardRechargeElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, "m_CardRechargeElement");
			IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_RegisteredElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, "m_RegisteredElement");
			IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_RemoveBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, "m_RemoveBuffer");
			IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_UpdatedSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, "m_UpdatedSet");
			IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_CurrentInstantiateField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, "m_CurrentInstantiateField");
			IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_Manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, "m_Manager");
			IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_ObjectPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, "m_ObjectPool");
			IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, 100673949);
			IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, 100673950);
			IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr_Initialize_Public_Void_DLC4_BossBattleManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, 100673951);
			IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr_UpdateVisual_Public_Void_IReadOnlyList_1_RechargeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, 100673952);
			IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, 100673953);
			IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, 100673954);
			IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr__Awake_b__10_0_Private_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, 100673955);
			IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr__Awake_b__10_1_Private_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, 100673956);
			IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr__Awake_b__10_2_Private_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, 100673957);
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x001600B4 File Offset: 0x0015E2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130581, XrefRangeEnd = 130620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600387B RID: 14459 RVA: 0x001600E8 File Offset: 0x0015E2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130620, XrefRangeEnd = 130624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x0016011C File Offset: 0x0015E31C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43501, RefRangeEnd = 43502, XrefRangeStart = 43501, XrefRangeEnd = 43502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(DLC4_BossBattleManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr_Initialize_Public_Void_DLC4_BossBattleManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x00160160 File Offset: 0x0015E360
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130715, RefRangeEnd = 130716, XrefRangeStart = 130624, XrefRangeEnd = 130715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual(IReadOnlyList<RechargeInfo> rechargeInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rechargeInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr_UpdateVisual_Public_Void_IReadOnlyList_1_RechargeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600387E RID: 14462 RVA: 0x001601A4 File Offset: 0x0015E3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130716, XrefRangeEnd = 130732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x001601E0 File Offset: 0x0015E3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130732, XrefRangeEnd = 130755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncomeControllerFlandre_CardRechargeIndicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x0016021C File Offset: 0x0015E41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130755, XrefRangeEnd = 130761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIElementCluster _Awake_b__10_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr__Awake_b__10_0_Private_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x0016025C File Offset: 0x0015E45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130761, XrefRangeEnd = 130766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__10_1(UIElementCluster instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr__Awake_b__10_1_Private_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x001602A0 File Offset: 0x0015E4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130766, XrefRangeEnd = 130771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__10_2(UIElementCluster instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre_CardRechargeIndicator.NativeMethodInfoPtr__Awake_b__10_2_Private_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x0001F7FF File Offset: 0x0001D9FF
		public IncomeControllerFlandre_CardRechargeIndicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06003884 RID: 14468 RVA: 0x001602E4 File Offset: 0x0015E4E4
		// (set) Token: 0x06003885 RID: 14469 RVA: 0x0001F808 File Offset: 0x0001DA08
		public unsafe RectTransform m_SpecialCardField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_SpecialCardField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_SpecialCardField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06003886 RID: 14470 RVA: 0x00160314 File Offset: 0x0015E514
		// (set) Token: 0x06003887 RID: 14471 RVA: 0x0001F827 File Offset: 0x0001DA27
		public unsafe RectTransform m_NormalCardField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_NormalCardField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_NormalCardField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06003888 RID: 14472 RVA: 0x00160344 File Offset: 0x0015E544
		// (set) Token: 0x06003889 RID: 14473 RVA: 0x0001F846 File Offset: 0x0001DA46
		public unsafe RectTransform m_BufferField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_BufferField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_BufferField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x0600388A RID: 14474 RVA: 0x00160374 File Offset: 0x0015E574
		// (set) Token: 0x0600388B RID: 14475 RVA: 0x0001F865 File Offset: 0x0001DA65
		public unsafe UIElementCluster m_CardRechargeElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_CardRechargeElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_CardRechargeElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x0600388C RID: 14476 RVA: 0x001603A4 File Offset: 0x0015E5A4
		// (set) Token: 0x0600388D RID: 14477 RVA: 0x0001F884 File Offset: 0x0001DA84
		public unsafe Dictionary<int, ValueTuple<UIElementCluster, Image>> m_RegisteredElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_RegisteredElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<UIElementCluster, Image>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_RegisteredElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x0600388E RID: 14478 RVA: 0x001603D4 File Offset: 0x0015E5D4
		// (set) Token: 0x0600388F RID: 14479 RVA: 0x0001F8A3 File Offset: 0x0001DAA3
		public unsafe Stack<int> m_RemoveBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_RemoveBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_RemoveBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06003890 RID: 14480 RVA: 0x00160404 File Offset: 0x0015E604
		// (set) Token: 0x06003891 RID: 14481 RVA: 0x0001F8C2 File Offset: 0x0001DAC2
		public unsafe HashSet<int> m_UpdatedSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_UpdatedSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_UpdatedSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06003892 RID: 14482 RVA: 0x00160434 File Offset: 0x0015E634
		// (set) Token: 0x06003893 RID: 14483 RVA: 0x0001F8E1 File Offset: 0x0001DAE1
		public unsafe RectTransform m_CurrentInstantiateField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_CurrentInstantiateField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_CurrentInstantiateField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x06003894 RID: 14484 RVA: 0x00160464 File Offset: 0x0015E664
		// (set) Token: 0x06003895 RID: 14485 RVA: 0x0001F900 File Offset: 0x0001DB00
		public unsafe DLC4_BossBattleManager m_Manager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_Manager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BossBattleManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_Manager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x06003896 RID: 14486 RVA: 0x00160494 File Offset: 0x0015E694
		// (set) Token: 0x06003897 RID: 14487 RVA: 0x0001F91F File Offset: 0x0001DB1F
		public unsafe ObjectPool<UIElementCluster> m_ObjectPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_ObjectPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<UIElementCluster>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.NativeFieldInfoPtr_m_ObjectPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002614 RID: 9748
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialCardField;

		// Token: 0x04002615 RID: 9749
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalCardField;

		// Token: 0x04002616 RID: 9750
		private static readonly IntPtr NativeFieldInfoPtr_m_BufferField;

		// Token: 0x04002617 RID: 9751
		private static readonly IntPtr NativeFieldInfoPtr_m_CardRechargeElement;

		// Token: 0x04002618 RID: 9752
		private static readonly IntPtr NativeFieldInfoPtr_m_RegisteredElement;

		// Token: 0x04002619 RID: 9753
		private static readonly IntPtr NativeFieldInfoPtr_m_RemoveBuffer;

		// Token: 0x0400261A RID: 9754
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdatedSet;

		// Token: 0x0400261B RID: 9755
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentInstantiateField;

		// Token: 0x0400261C RID: 9756
		private static readonly IntPtr NativeFieldInfoPtr_m_Manager;

		// Token: 0x0400261D RID: 9757
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectPool;

		// Token: 0x0400261E RID: 9758
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400261F RID: 9759
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002620 RID: 9760
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_DLC4_BossBattleManager_0;

		// Token: 0x04002621 RID: 9761
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Public_Void_IReadOnlyList_1_RechargeInfo_0;

		// Token: 0x04002622 RID: 9762
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04002623 RID: 9763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002624 RID: 9764
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__10_0_Private_UIElementCluster_0;

		// Token: 0x04002625 RID: 9765
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__10_1_Private_Void_UIElementCluster_0;

		// Token: 0x04002626 RID: 9766
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__10_2_Private_Void_UIElementCluster_0;

		// Token: 0x02000940 RID: 2368
		[ObfuscatedName("NightScene.UI.HUDUtility.IncomeControllerFlandre_CardRechargeIndicator+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600B9C0 RID: 47552 RVA: 0x002EE160 File Offset: 0x002EC360
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator.__c>.NativeClassPtr);
				IncomeControllerFlandre_CardRechargeIndicator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator.__c>.NativeClassPtr, "<>9");
				IncomeControllerFlandre_CardRechargeIndicator.__c.NativeFieldInfoPtr___9__10_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator.__c>.NativeClassPtr, "<>9__10_3");
				IncomeControllerFlandre_CardRechargeIndicator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator.__c>.NativeClassPtr, 100673959);
				IncomeControllerFlandre_CardRechargeIndicator.__c.NativeMethodInfoPtr__Awake_b__10_3_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator.__c>.NativeClassPtr, 100673960);
			}

			// Token: 0x0600B9C1 RID: 47553 RVA: 0x002EE1DC File Offset: 0x002EC3DC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre_CardRechargeIndicator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9C2 RID: 47554 RVA: 0x002EE218 File Offset: 0x002EC418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130573, XrefRangeEnd = 130579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__10_3(UIElementCluster instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre_CardRechargeIndicator.__c.NativeMethodInfoPtr__Awake_b__10_3_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9C3 RID: 47555 RVA: 0x00064424 File Offset: 0x00062624
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CD6 RID: 15574
			// (get) Token: 0x0600B9C4 RID: 47556 RVA: 0x002EE25C File Offset: 0x002EC45C
			// (set) Token: 0x0600B9C5 RID: 47557 RVA: 0x0006442D File Offset: 0x0006262D
			public unsafe static IncomeControllerFlandre_CardRechargeIndicator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IncomeControllerFlandre_CardRechargeIndicator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerFlandre_CardRechargeIndicator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IncomeControllerFlandre_CardRechargeIndicator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CD7 RID: 15575
			// (get) Token: 0x0600B9C6 RID: 47558 RVA: 0x002EE284 File Offset: 0x002EC484
			// (set) Token: 0x0600B9C7 RID: 47559 RVA: 0x0006443F File Offset: 0x0006263F
			public unsafe static Action<UIElementCluster> __9__10_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IncomeControllerFlandre_CardRechargeIndicator.__c.NativeFieldInfoPtr___9__10_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IncomeControllerFlandre_CardRechargeIndicator.__c.NativeFieldInfoPtr___9__10_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007805 RID: 30725
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007806 RID: 30726
			private static readonly IntPtr NativeFieldInfoPtr___9__10_3;

			// Token: 0x04007807 RID: 30727
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007808 RID: 30728
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__10_3_Internal_Void_UIElementCluster_0;
		}

		// Token: 0x02000941 RID: 2369
		[ObfuscatedName("NightScene.UI.HUDUtility.IncomeControllerFlandre_CardRechargeIndicator+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B9C8 RID: 47560 RVA: 0x002EE2AC File Offset: 0x002EC4AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator.__c__DisplayClass13_0>.NativeClassPtr);
				IncomeControllerFlandre_CardRechargeIndicator.__c__DisplayClass13_0.NativeFieldInfoPtr_registered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator.__c__DisplayClass13_0>.NativeClassPtr, "registered");
				IncomeControllerFlandre_CardRechargeIndicator.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator.__c__DisplayClass13_0>.NativeClassPtr, 100673961);
				IncomeControllerFlandre_CardRechargeIndicator.__c__DisplayClass13_0.NativeMethodInfoPtr__UpdateVisual_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator.__c__DisplayClass13_0>.NativeClassPtr, 100673962);
			}

			// Token: 0x0600B9C9 RID: 47561 RVA: 0x002EE314 File Offset: 0x002EC514
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerFlandre_CardRechargeIndicator.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre_CardRechargeIndicator.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9CA RID: 47562 RVA: 0x002EE350 File Offset: 0x002EC550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130579, XrefRangeEnd = 130581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateVisual_b__0(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerFlandre_CardRechargeIndicator.__c__DisplayClass13_0.NativeMethodInfoPtr__UpdateVisual_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9CB RID: 47563 RVA: 0x00064451 File Offset: 0x00062651
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CD8 RID: 15576
			// (get) Token: 0x0600B9CC RID: 47564 RVA: 0x002EE390 File Offset: 0x002EC590
			// (set) Token: 0x0600B9CD RID: 47565 RVA: 0x0006445A File Offset: 0x0006265A
			public ValueTuple<UIElementCluster, Image> registered
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.__c__DisplayClass13_0.NativeFieldInfoPtr_registered);
					return new ValueTuple<UIElementCluster, Image>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<UIElementCluster, Image>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerFlandre_CardRechargeIndicator.__c__DisplayClass13_0.NativeFieldInfoPtr_registered), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<UIElementCluster, Image>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04007809 RID: 30729
			private static readonly IntPtr NativeFieldInfoPtr_registered;

			// Token: 0x0400780A RID: 30730
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400780B RID: 30731
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVisual_b__0_Internal_Void_Single_0;
		}
	}
}
