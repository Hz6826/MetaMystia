using System;
using System.Runtime.InteropServices;
using DEYU.AdpUISystem.LogicalCollection;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000393 RID: 915
	public class IntractableNewsObject : MonoBehaviour
	{
		// Token: 0x06006DB0 RID: 28080 RVA: 0x0020C498 File Offset: 0x0020A698
		// Note: this type is marked as 'beforefieldinit'.
		static IntractableNewsObject()
		{
			Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.NoteBookUtility", "IntractableNewsObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr);
			IntractableNewsObject.NativeFieldInfoPtr__CanvasGroupComponent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr, "<CanvasGroupComponent>k__BackingField");
			IntractableNewsObject.NativeFieldInfoPtr__UIButtonSimpleComponent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr, "<UIButtonSimpleComponent>k__BackingField");
			IntractableNewsObject.NativeFieldInfoPtr_m_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr, "m_Title");
			IntractableNewsObject.NativeFieldInfoPtr_m_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr, "m_Content");
			IntractableNewsObject.NativeFieldInfoPtr_m_Date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr, "m_Date");
			IntractableNewsObject.NativeFieldInfoPtr_m_OnSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr, "m_OnSubmit");
			IntractableNewsObject.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr, 100685800);
			IntractableNewsObject.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr, 100685801);
			IntractableNewsObject.NativeMethodInfoPtr_get_CanvasGroupComponent_Public_get_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr, 100685802);
			IntractableNewsObject.NativeMethodInfoPtr_set_CanvasGroupComponent_Private_set_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr, 100685803);
			IntractableNewsObject.NativeMethodInfoPtr_get_UIButtonSimpleComponent_Public_get_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr, 100685804);
			IntractableNewsObject.NativeMethodInfoPtr_set_UIButtonSimpleComponent_Private_set_Void_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr, 100685805);
			IntractableNewsObject.NativeMethodInfoPtr_SetValue_Public_Void_byref_HistoryNewsData_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr, 100685806);
			IntractableNewsObject.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr, 100685807);
			IntractableNewsObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr, 100685808);
			IntractableNewsObject.NativeMethodInfoPtr__Awake_b__1_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr, 100685809);
		}

		// Token: 0x06006DB1 RID: 28081 RVA: 0x0020C608 File Offset: 0x0020A808
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntractableNewsObject.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DB2 RID: 28082 RVA: 0x0020C63C File Offset: 0x0020A83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275542, XrefRangeEnd = 275560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntractableNewsObject.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002593 RID: 9619
		// (get) Token: 0x06006DB3 RID: 28083 RVA: 0x0020C670 File Offset: 0x0020A870
		// (set) Token: 0x06006DB4 RID: 28084 RVA: 0x0020C6B0 File Offset: 0x0020A8B0
		public unsafe CanvasGroup CanvasGroupComponent
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntractableNewsObject.NativeMethodInfoPtr_get_CanvasGroupComponent_Public_get_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 157625, RefRangeEnd = 157629, XrefRangeStart = 157625, XrefRangeEnd = 157629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntractableNewsObject.NativeMethodInfoPtr_set_CanvasGroupComponent_Private_set_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002594 RID: 9620
		// (get) Token: 0x06006DB5 RID: 28085 RVA: 0x0020C6F4 File Offset: 0x0020A8F4
		// (set) Token: 0x06006DB6 RID: 28086 RVA: 0x0020C734 File Offset: 0x0020A934
		public unsafe UIButtonSimple UIButtonSimpleComponent
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntractableNewsObject.NativeMethodInfoPtr_get_UIButtonSimpleComponent_Public_get_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49354, RefRangeEnd = 49355, XrefRangeStart = 49354, XrefRangeEnd = 49355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntractableNewsObject.NativeMethodInfoPtr_set_UIButtonSimpleComponent_Private_set_Void_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006DB7 RID: 28087 RVA: 0x0020C778 File Offset: 0x0020A978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275560, XrefRangeEnd = 275565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue([In] ref RunTimeScheduler.HistoryNewsData newsData, Action onSubmit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(newsData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onSubmit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntractableNewsObject.NativeMethodInfoPtr_SetValue_Public_Void_byref_HistoryNewsData_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DB8 RID: 28088 RVA: 0x0020C7D0 File Offset: 0x0020A9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntractableNewsObject.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DB9 RID: 28089 RVA: 0x0020C80C File Offset: 0x0020AA0C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntractableNewsObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntractableNewsObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntractableNewsObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DBA RID: 28090 RVA: 0x0020C848 File Offset: 0x0020AA48
		[CallerCount(0)]
		public unsafe void _Awake_b__1_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntractableNewsObject.NativeMethodInfoPtr__Awake_b__1_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DBB RID: 28091 RVA: 0x0003B4DE File Offset: 0x000396DE
		public IntractableNewsObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700258D RID: 9613
		// (get) Token: 0x06006DBC RID: 28092 RVA: 0x0020C87C File Offset: 0x0020AA7C
		// (set) Token: 0x06006DBD RID: 28093 RVA: 0x0003B4E7 File Offset: 0x000396E7
		public unsafe CanvasGroup _CanvasGroupComponent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntractableNewsObject.NativeFieldInfoPtr__CanvasGroupComponent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntractableNewsObject.NativeFieldInfoPtr__CanvasGroupComponent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700258E RID: 9614
		// (get) Token: 0x06006DBE RID: 28094 RVA: 0x0020C8AC File Offset: 0x0020AAAC
		// (set) Token: 0x06006DBF RID: 28095 RVA: 0x0003B506 File Offset: 0x00039706
		public unsafe UIButtonSimple _UIButtonSimpleComponent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntractableNewsObject.NativeFieldInfoPtr__UIButtonSimpleComponent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntractableNewsObject.NativeFieldInfoPtr__UIButtonSimpleComponent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700258F RID: 9615
		// (get) Token: 0x06006DC0 RID: 28096 RVA: 0x0020C8DC File Offset: 0x0020AADC
		// (set) Token: 0x06006DC1 RID: 28097 RVA: 0x0003B525 File Offset: 0x00039725
		public unsafe TextMeshProUGUI m_Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntractableNewsObject.NativeFieldInfoPtr_m_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntractableNewsObject.NativeFieldInfoPtr_m_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002590 RID: 9616
		// (get) Token: 0x06006DC2 RID: 28098 RVA: 0x0020C90C File Offset: 0x0020AB0C
		// (set) Token: 0x06006DC3 RID: 28099 RVA: 0x0003B544 File Offset: 0x00039744
		public unsafe TextMeshProUGUI m_Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntractableNewsObject.NativeFieldInfoPtr_m_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntractableNewsObject.NativeFieldInfoPtr_m_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002591 RID: 9617
		// (get) Token: 0x06006DC4 RID: 28100 RVA: 0x0020C93C File Offset: 0x0020AB3C
		// (set) Token: 0x06006DC5 RID: 28101 RVA: 0x0003B563 File Offset: 0x00039763
		public unsafe TextMeshProUGUI m_Date
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntractableNewsObject.NativeFieldInfoPtr_m_Date);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntractableNewsObject.NativeFieldInfoPtr_m_Date), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002592 RID: 9618
		// (get) Token: 0x06006DC6 RID: 28102 RVA: 0x0020C96C File Offset: 0x0020AB6C
		// (set) Token: 0x06006DC7 RID: 28103 RVA: 0x0003B582 File Offset: 0x00039782
		public unsafe Action m_OnSubmit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntractableNewsObject.NativeFieldInfoPtr_m_OnSubmit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntractableNewsObject.NativeFieldInfoPtr_m_OnSubmit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040048BE RID: 18622
		private static readonly IntPtr NativeFieldInfoPtr__CanvasGroupComponent_k__BackingField;

		// Token: 0x040048BF RID: 18623
		private static readonly IntPtr NativeFieldInfoPtr__UIButtonSimpleComponent_k__BackingField;

		// Token: 0x040048C0 RID: 18624
		private static readonly IntPtr NativeFieldInfoPtr_m_Title;

		// Token: 0x040048C1 RID: 18625
		private static readonly IntPtr NativeFieldInfoPtr_m_Content;

		// Token: 0x040048C2 RID: 18626
		private static readonly IntPtr NativeFieldInfoPtr_m_Date;

		// Token: 0x040048C3 RID: 18627
		private static readonly IntPtr NativeFieldInfoPtr_m_OnSubmit;

		// Token: 0x040048C4 RID: 18628
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040048C5 RID: 18629
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040048C6 RID: 18630
		private static readonly IntPtr NativeMethodInfoPtr_get_CanvasGroupComponent_Public_get_CanvasGroup_0;

		// Token: 0x040048C7 RID: 18631
		private static readonly IntPtr NativeMethodInfoPtr_set_CanvasGroupComponent_Private_set_Void_CanvasGroup_0;

		// Token: 0x040048C8 RID: 18632
		private static readonly IntPtr NativeMethodInfoPtr_get_UIButtonSimpleComponent_Public_get_UIButtonSimple_0;

		// Token: 0x040048C9 RID: 18633
		private static readonly IntPtr NativeMethodInfoPtr_set_UIButtonSimpleComponent_Private_set_Void_UIButtonSimple_0;

		// Token: 0x040048CA RID: 18634
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_byref_HistoryNewsData_Action_0;

		// Token: 0x040048CB RID: 18635
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040048CC RID: 18636
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040048CD RID: 18637
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__1_0_Private_Void_0;
	}
}
