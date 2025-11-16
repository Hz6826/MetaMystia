using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;

namespace DayScene.UI
{
	// Token: 0x020000D0 RID: 208
	public class FastTravelPanel_TimeIndicator : MonoBehaviour
	{
		// Token: 0x060018E3 RID: 6371 RVA: 0x000F10EC File Offset: 0x000EF2EC
		// Note: this type is marked as 'beforefieldinit'.
		static FastTravelPanel_TimeIndicator()
		{
			Il2CppClassPointerStore<FastTravelPanel_TimeIndicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "FastTravelPanel_TimeIndicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastTravelPanel_TimeIndicator>.NativeClassPtr);
			FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_CurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_TimeIndicator>.NativeClassPtr, "m_CurrentTime");
			FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_TargetTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_TimeIndicator>.NativeClassPtr, "m_TargetTime");
			FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_CostTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_TimeIndicator>.NativeClassPtr, "m_CostTime");
			FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_CostMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_TimeIndicator>.NativeClassPtr, "m_CostMoney");
			FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_CostMoneyPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_TimeIndicator>.NativeClassPtr, "m_CostMoneyPanel");
			FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_FloatMenuRig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_TimeIndicator>.NativeClassPtr, "m_FloatMenuRig");
			FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_TimeIndicator>.NativeClassPtr, "m_CanvasGroup");
			FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_StartOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_TimeIndicator>.NativeClassPtr, "m_StartOffset");
			FastTravelPanel_TimeIndicator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_TimeIndicator>.NativeClassPtr, 100667709);
			FastTravelPanel_TimeIndicator.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Nullable_1_TimeIndicatorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_TimeIndicator>.NativeClassPtr, 100667710);
			FastTravelPanel_TimeIndicator.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_TimeIndicator>.NativeClassPtr, 100667711);
			FastTravelPanel_TimeIndicator.NativeMethodInfoPtr_ApplyOffset_Public_Void_Nullable_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_TimeIndicator>.NativeClassPtr, 100667712);
			FastTravelPanel_TimeIndicator.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_TimeIndicator>.NativeClassPtr, 100667713);
			FastTravelPanel_TimeIndicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_TimeIndicator>.NativeClassPtr, 100667714);
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x000F1234 File Offset: 0x000EF434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67513, XrefRangeEnd = 67518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_TimeIndicator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x000F1268 File Offset: 0x000EF468
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 67540, RefRangeEnd = 67544, XrefRangeStart = 67518, XrefRangeEnd = 67540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValue(Nullable<TimeIndicatorContext> context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_TimeIndicator.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Nullable_1_TimeIndicatorContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x000F12B0 File Offset: 0x000EF4B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 67544, RefRangeEnd = 67546, XrefRangeStart = 67544, XrefRangeEnd = 67544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_TimeIndicator.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x000F12E4 File Offset: 0x000EF4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67546, XrefRangeEnd = 67551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyOffset(Nullable<Vector2> offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(offset));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_TimeIndicator.NativeMethodInfoPtr_ApplyOffset_Public_Void_Nullable_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x000F132C File Offset: 0x000EF52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67551, XrefRangeEnd = 67558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FastTravelPanel_TimeIndicator.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x000F1368 File Offset: 0x000EF568
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FastTravelPanel_TimeIndicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastTravelPanel_TimeIndicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_TimeIndicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x0000F880 File Offset: 0x0000DA80
		public FastTravelPanel_TimeIndicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x000F13A4 File Offset: 0x000EF5A4
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x0000F889 File Offset: 0x0000DA89
		public unsafe TextMeshProUGUI m_CurrentTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_CurrentTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_CurrentTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x000F13D4 File Offset: 0x000EF5D4
		// (set) Token: 0x060018EE RID: 6382 RVA: 0x0000F8A8 File Offset: 0x0000DAA8
		public unsafe TextMeshProUGUI m_TargetTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_TargetTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_TargetTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x000F1404 File Offset: 0x000EF604
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x0000F8C7 File Offset: 0x0000DAC7
		public unsafe TextMeshProUGUI m_CostTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_CostTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_CostTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x000F1434 File Offset: 0x000EF634
		// (set) Token: 0x060018F2 RID: 6386 RVA: 0x0000F8E6 File Offset: 0x0000DAE6
		public unsafe TextMeshProUGUI m_CostMoney
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_CostMoney);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_CostMoney), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x000F1464 File Offset: 0x000EF664
		// (set) Token: 0x060018F4 RID: 6388 RVA: 0x0000F905 File Offset: 0x0000DB05
		public unsafe GameObject m_CostMoneyPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_CostMoneyPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_CostMoneyPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x000F1494 File Offset: 0x000EF694
		// (set) Token: 0x060018F6 RID: 6390 RVA: 0x0000F924 File Offset: 0x0000DB24
		public unsafe RectTransform m_FloatMenuRig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_FloatMenuRig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_FloatMenuRig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x000F14C4 File Offset: 0x000EF6C4
		// (set) Token: 0x060018F8 RID: 6392 RVA: 0x0000F943 File Offset: 0x0000DB43
		public unsafe CanvasGroup m_CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x000F14F4 File Offset: 0x000EF6F4
		// (set) Token: 0x060018FA RID: 6394 RVA: 0x0000F962 File Offset: 0x0000DB62
		public unsafe Vector2 m_StartOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_StartOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_TimeIndicator.NativeFieldInfoPtr_m_StartOffset)) = value;
			}
		}

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentTime;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetTime;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeFieldInfoPtr_m_CostTime;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeFieldInfoPtr_m_CostMoney;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeFieldInfoPtr_m_CostMoneyPanel;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeFieldInfoPtr_m_FloatMenuRig;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasGroup;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeFieldInfoPtr_m_StartOffset;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Nullable_1_TimeIndicatorContext_0;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr_ApplyOffset_Public_Void_Nullable_1_Vector2_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
