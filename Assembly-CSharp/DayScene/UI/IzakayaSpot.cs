using System;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020000B7 RID: 183
	public class IzakayaSpot : MonoBehaviour
	{
		// Token: 0x060013E5 RID: 5093 RVA: 0x000E1518 File Offset: 0x000DF718
		// Note: this type is marked as 'beforefieldinit'.
		static IzakayaSpot()
		{
			Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "IzakayaSpot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr);
			IzakayaSpot.NativeFieldInfoPtr_daySceneMapId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, "daySceneMapId");
			IzakayaSpot.NativeFieldInfoPtr_izakayaIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, "izakayaIndicator");
			IzakayaSpot.NativeFieldInfoPtr_normalIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, "normalIndicator");
			IzakayaSpot.NativeFieldInfoPtr_level1Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, "level1Icon");
			IzakayaSpot.NativeFieldInfoPtr_level2Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, "level2Icon");
			IzakayaSpot.NativeFieldInfoPtr_level3Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, "level3Icon");
			IzakayaSpot.NativeFieldInfoPtr_levelIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, "levelIndicator");
			IzakayaSpot.NativeFieldInfoPtr_parentVisualNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, "parentVisualNode");
			IzakayaSpot.NativeFieldInfoPtr_highlightInidicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, "highlightInidicator");
			IzakayaSpot.NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, "interactable");
			IzakayaSpot.NativeMethodInfoPtr_get_Activated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, 100666746);
			IzakayaSpot.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, 100666747);
			IzakayaSpot.NativeMethodInfoPtr_SetOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, 100666748);
			IzakayaSpot.NativeMethodInfoPtr_SetOn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, 100666749);
			IzakayaSpot.NativeMethodInfoPtr_Select_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, 100666750);
			IzakayaSpot.NativeMethodInfoPtr_Initialize_Public_Boolean_Action_1_List_1_Int32_Func_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, 100666751);
			IzakayaSpot.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, 100666752);
			IzakayaSpot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, 100666753);
			IzakayaSpot.NativeMethodInfoPtr__Initialize_b__17_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, 100666754);
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x000E16C4 File Offset: 0x000DF8C4
		public unsafe bool Activated
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 54961, RefRangeEnd = 54963, XrefRangeStart = 54961, XrefRangeEnd = 54961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.NativeMethodInfoPtr_get_Activated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x000E1700 File Offset: 0x000DF900
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x000E1734 File Offset: 0x000DF934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54965, RefRangeEnd = 54966, XrefRangeStart = 54963, XrefRangeEnd = 54965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.NativeMethodInfoPtr_SetOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x000E1768 File Offset: 0x000DF968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54966, XrefRangeEnd = 54968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.NativeMethodInfoPtr_SetOn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x000E179C File Offset: 0x000DF99C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54969, RefRangeEnd = 54970, XrefRangeStart = 54968, XrefRangeEnd = 54969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.NativeMethodInfoPtr_Select_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x000E17D0 File Offset: 0x000DF9D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55183, RefRangeEnd = 55184, XrefRangeStart = 54970, XrefRangeEnd = 55183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Initialize(Action<List<int>> onSelectAction, Func<int, bool> getOverrideOpenStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onSelectAction);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getOverrideOpenStatus);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.NativeMethodInfoPtr_Initialize_Public_Boolean_Action_1_List_1_Int32_Func_2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x000E1830 File Offset: 0x000DFA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55184, XrefRangeEnd = 55194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaSpot.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x000E186C File Offset: 0x000DFA6C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IzakayaSpot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x000E18A8 File Offset: 0x000DFAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55194, XrefRangeEnd = 55196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__17_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.NativeMethodInfoPtr__Initialize_b__17_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x0000C7E8 File Offset: 0x0000A9E8
		public IzakayaSpot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x000E18DC File Offset: 0x000DFADC
		// (set) Token: 0x060013F1 RID: 5105 RVA: 0x0000C7F1 File Offset: 0x0000A9F1
		public unsafe string daySceneMapId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_daySceneMapId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_daySceneMapId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x000E1904 File Offset: 0x000DFB04
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x0000C810 File Offset: 0x0000AA10
		public unsafe Image izakayaIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_izakayaIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_izakayaIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x000E1934 File Offset: 0x000DFB34
		// (set) Token: 0x060013F5 RID: 5109 RVA: 0x0000C82F File Offset: 0x0000AA2F
		public unsafe Image normalIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_normalIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_normalIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x000E1964 File Offset: 0x000DFB64
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x0000C84E File Offset: 0x0000AA4E
		public unsafe Image level1Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_level1Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_level1Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x000E1994 File Offset: 0x000DFB94
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x0000C86D File Offset: 0x0000AA6D
		public unsafe Image level2Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_level2Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_level2Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x000E19C4 File Offset: 0x000DFBC4
		// (set) Token: 0x060013FB RID: 5115 RVA: 0x0000C88C File Offset: 0x0000AA8C
		public unsafe Image level3Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_level3Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_level3Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x000E19F4 File Offset: 0x000DFBF4
		// (set) Token: 0x060013FD RID: 5117 RVA: 0x0000C8AB File Offset: 0x0000AAAB
		public unsafe GameObject levelIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_levelIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_levelIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x000E1A24 File Offset: 0x000DFC24
		// (set) Token: 0x060013FF RID: 5119 RVA: 0x0000C8CA File Offset: 0x0000AACA
		public unsafe GameObject parentVisualNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_parentVisualNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_parentVisualNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x000E1A54 File Offset: 0x000DFC54
		// (set) Token: 0x06001401 RID: 5121 RVA: 0x0000C8E9 File Offset: 0x0000AAE9
		public unsafe Sprite highlightInidicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_highlightInidicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_highlightInidicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x000E1A84 File Offset: 0x000DFC84
		// (set) Token: 0x06001403 RID: 5123 RVA: 0x0000C908 File Offset: 0x0000AB08
		public unsafe UIButtonSimple interactable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_interactable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.NativeFieldInfoPtr_interactable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeFieldInfoPtr_daySceneMapId;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeFieldInfoPtr_izakayaIndicator;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeFieldInfoPtr_normalIndicator;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeFieldInfoPtr_level1Icon;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeFieldInfoPtr_level2Icon;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeFieldInfoPtr_level3Icon;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeFieldInfoPtr_levelIndicator;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeFieldInfoPtr_parentVisualNode;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeFieldInfoPtr_highlightInidicator;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeFieldInfoPtr_interactable;

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeMethodInfoPtr_get_Activated_Public_get_Boolean_0;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeMethodInfoPtr_SetOff_Public_Void_0;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeMethodInfoPtr_SetOn_Public_Void_0;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Void_0;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Boolean_Action_1_List_1_Int32_Func_2_Int32_Boolean_0;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_4_Private_Void_0;

		// Token: 0x020005DC RID: 1500
		public enum LevelSelectionType
		{
			// Token: 0x04005CC5 RID: 23749
			Level1,
			// Token: 0x04005CC6 RID: 23750
			Level2,
			// Token: 0x04005CC7 RID: 23751
			Level3
		}

		// Token: 0x020005DD RID: 1501
		[ObfuscatedName("DayScene.UI.IzakayaSpot+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x06008E17 RID: 36375 RVA: 0x0026DDC4 File Offset: 0x0026BFC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<IzakayaSpot.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaSpot.__c__DisplayClass17_0>.NativeClassPtr);
				IzakayaSpot.__c__DisplayClass17_0.NativeFieldInfoPtr_currentOnSelectAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot.__c__DisplayClass17_0>.NativeClassPtr, "currentOnSelectAction");
				IzakayaSpot.__c__DisplayClass17_0.NativeFieldInfoPtr_availableIzakayaIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot.__c__DisplayClass17_0>.NativeClassPtr, "availableIzakayaIds");
				IzakayaSpot.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				IzakayaSpot.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot.__c__DisplayClass17_0>.NativeClassPtr, 100666755);
				IzakayaSpot.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot.__c__DisplayClass17_0>.NativeClassPtr, 100666756);
			}

			// Token: 0x06008E18 RID: 36376 RVA: 0x0026DE54 File Offset: 0x0026C054
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaSpot.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E19 RID: 36377 RVA: 0x0026DE90 File Offset: 0x0026C090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54950, XrefRangeEnd = 54952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E1A RID: 36378 RVA: 0x0004C849 File Offset: 0x0004AA49
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F80 RID: 12160
			// (get) Token: 0x06008E1B RID: 36379 RVA: 0x0026DEC4 File Offset: 0x0026C0C4
			// (set) Token: 0x06008E1C RID: 36380 RVA: 0x0004C852 File Offset: 0x0004AA52
			public unsafe Action<List<int>> currentOnSelectAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.__c__DisplayClass17_0.NativeFieldInfoPtr_currentOnSelectAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.__c__DisplayClass17_0.NativeFieldInfoPtr_currentOnSelectAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F81 RID: 12161
			// (get) Token: 0x06008E1D RID: 36381 RVA: 0x0026DEF4 File Offset: 0x0026C0F4
			// (set) Token: 0x06008E1E RID: 36382 RVA: 0x0004C871 File Offset: 0x0004AA71
			public unsafe List<int> availableIzakayaIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.__c__DisplayClass17_0.NativeFieldInfoPtr_availableIzakayaIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.__c__DisplayClass17_0.NativeFieldInfoPtr_availableIzakayaIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F82 RID: 12162
			// (get) Token: 0x06008E1F RID: 36383 RVA: 0x0026DF24 File Offset: 0x0026C124
			// (set) Token: 0x06008E20 RID: 36384 RVA: 0x0004C890 File Offset: 0x0004AA90
			public unsafe IzakayaSpot __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaSpot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaSpot.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005CC8 RID: 23752
			private static readonly IntPtr NativeFieldInfoPtr_currentOnSelectAction;

			// Token: 0x04005CC9 RID: 23753
			private static readonly IntPtr NativeFieldInfoPtr_availableIzakayaIds;

			// Token: 0x04005CCA RID: 23754
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005CCB RID: 23755
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005CCC RID: 23756
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x020005DE RID: 1502
		[ObfuscatedName("DayScene.UI.IzakayaSpot+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008E21 RID: 36385 RVA: 0x0026DF54 File Offset: 0x0026C154
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaSpot>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr);
				IzakayaSpot.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, "<>9");
				IzakayaSpot.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, "<>9__17_0");
				IzakayaSpot.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, "<>9__17_1");
				IzakayaSpot.__c.NativeFieldInfoPtr___9__17_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, "<>9__17_2");
				IzakayaSpot.__c.NativeFieldInfoPtr___9__17_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, "<>9__17_5");
				IzakayaSpot.__c.NativeFieldInfoPtr___9__17_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, "<>9__17_6");
				IzakayaSpot.__c.NativeFieldInfoPtr___9__17_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, "<>9__17_7");
				IzakayaSpot.__c.NativeFieldInfoPtr___9__17_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, "<>9__17_8");
				IzakayaSpot.__c.NativeFieldInfoPtr___9__17_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, "<>9__17_9");
				IzakayaSpot.__c.NativeFieldInfoPtr___9__17_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, "<>9__17_10");
				IzakayaSpot.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, 100666758);
				IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_0_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, 100666759);
				IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_1_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, 100666760);
				IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_2_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, 100666761);
				IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_5_Internal_ValueTuple_2_Int32_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, 100666762);
				IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_6_Internal_Boolean_ValueTuple_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, 100666763);
				IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_7_Internal_ValueTuple_2_Int32_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, 100666764);
				IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_8_Internal_Boolean_ValueTuple_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, 100666765);
				IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_9_Internal_ValueTuple_2_Int32_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, 100666766);
				IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_10_Internal_Boolean_ValueTuple_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr, 100666767);
			}

			// Token: 0x06008E22 RID: 36386 RVA: 0x0026E110 File Offset: 0x0026C310
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaSpot.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E23 RID: 36387 RVA: 0x0026E14C File Offset: 0x0026C34C
			[CallerCount(0)]
			public unsafe bool _Initialize_b__17_0(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_0_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008E24 RID: 36388 RVA: 0x0026E198 File Offset: 0x0026C398
			[CallerCount(0)]
			public unsafe bool _Initialize_b__17_1(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_1_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008E25 RID: 36389 RVA: 0x0026E1E4 File Offset: 0x0026C3E4
			[CallerCount(0)]
			public unsafe bool _Initialize_b__17_2(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_2_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008E26 RID: 36390 RVA: 0x0026E230 File Offset: 0x0026C430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54952, XrefRangeEnd = 54955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<int, bool> _Initialize_b__17_5(int a, bool b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_5_Internal_ValueTuple_2_Int32_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<int, bool>(pointer);
			}

			// Token: 0x06008E27 RID: 36391 RVA: 0x0026E284 File Offset: 0x0026C484
			[CallerCount(0)]
			public unsafe bool _Initialize_b__17_6(ValueTuple<int, bool> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_6_Internal_Boolean_ValueTuple_2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008E28 RID: 36392 RVA: 0x0026E2D8 File Offset: 0x0026C4D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54955, XrefRangeEnd = 54958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<int, bool> _Initialize_b__17_7(int a, bool b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_7_Internal_ValueTuple_2_Int32_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<int, bool>(pointer);
			}

			// Token: 0x06008E29 RID: 36393 RVA: 0x0026E32C File Offset: 0x0026C52C
			[CallerCount(0)]
			public unsafe bool _Initialize_b__17_8(ValueTuple<int, bool> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_8_Internal_Boolean_ValueTuple_2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008E2A RID: 36394 RVA: 0x0026E380 File Offset: 0x0026C580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54958, XrefRangeEnd = 54961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<int, bool> _Initialize_b__17_9(int a, bool b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_9_Internal_ValueTuple_2_Int32_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<int, bool>(pointer);
			}

			// Token: 0x06008E2B RID: 36395 RVA: 0x0026E3D4 File Offset: 0x0026C5D4
			[CallerCount(0)]
			public unsafe bool _Initialize_b__17_10(ValueTuple<int, bool> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaSpot.__c.NativeMethodInfoPtr__Initialize_b__17_10_Internal_Boolean_ValueTuple_2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008E2C RID: 36396 RVA: 0x0004C8AF File Offset: 0x0004AAAF
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F83 RID: 12163
			// (get) Token: 0x06008E2D RID: 36397 RVA: 0x0026E428 File Offset: 0x0026C628
			// (set) Token: 0x06008E2E RID: 36398 RVA: 0x0004C8B8 File Offset: 0x0004AAB8
			public unsafe static IzakayaSpot.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaSpot.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaSpot.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaSpot.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F84 RID: 12164
			// (get) Token: 0x06008E2F RID: 36399 RVA: 0x0026E450 File Offset: 0x0026C650
			// (set) Token: 0x06008E30 RID: 36400 RVA: 0x0004C8CA File Offset: 0x0004AACA
			public unsafe static Func<bool, bool> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F85 RID: 12165
			// (get) Token: 0x06008E31 RID: 36401 RVA: 0x0026E478 File Offset: 0x0026C678
			// (set) Token: 0x06008E32 RID: 36402 RVA: 0x0004C8DC File Offset: 0x0004AADC
			public unsafe static Func<bool, bool> __9__17_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F86 RID: 12166
			// (get) Token: 0x06008E33 RID: 36403 RVA: 0x0026E4A0 File Offset: 0x0026C6A0
			// (set) Token: 0x06008E34 RID: 36404 RVA: 0x0004C8EE File Offset: 0x0004AAEE
			public unsafe static Func<bool, bool> __9__17_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F87 RID: 12167
			// (get) Token: 0x06008E35 RID: 36405 RVA: 0x0026E4C8 File Offset: 0x0026C6C8
			// (set) Token: 0x06008E36 RID: 36406 RVA: 0x0004C900 File Offset: 0x0004AB00
			public unsafe static Func<int, bool, ValueTuple<int, bool>> __9__17_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool, ValueTuple<int, bool>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F88 RID: 12168
			// (get) Token: 0x06008E37 RID: 36407 RVA: 0x0026E4F0 File Offset: 0x0026C6F0
			// (set) Token: 0x06008E38 RID: 36408 RVA: 0x0004C912 File Offset: 0x0004AB12
			public unsafe static Func<ValueTuple<int, bool>, bool> __9__17_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, bool>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F89 RID: 12169
			// (get) Token: 0x06008E39 RID: 36409 RVA: 0x0026E518 File Offset: 0x0026C718
			// (set) Token: 0x06008E3A RID: 36410 RVA: 0x0004C924 File Offset: 0x0004AB24
			public unsafe static Func<int, bool, ValueTuple<int, bool>> __9__17_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool, ValueTuple<int, bool>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F8A RID: 12170
			// (get) Token: 0x06008E3B RID: 36411 RVA: 0x0026E540 File Offset: 0x0026C740
			// (set) Token: 0x06008E3C RID: 36412 RVA: 0x0004C936 File Offset: 0x0004AB36
			public unsafe static Func<ValueTuple<int, bool>, bool> __9__17_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, bool>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F8B RID: 12171
			// (get) Token: 0x06008E3D RID: 36413 RVA: 0x0026E568 File Offset: 0x0026C768
			// (set) Token: 0x06008E3E RID: 36414 RVA: 0x0004C948 File Offset: 0x0004AB48
			public unsafe static Func<int, bool, ValueTuple<int, bool>> __9__17_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool, ValueTuple<int, bool>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F8C RID: 12172
			// (get) Token: 0x06008E3F RID: 36415 RVA: 0x0026E590 File Offset: 0x0026C790
			// (set) Token: 0x06008E40 RID: 36416 RVA: 0x0004C95A File Offset: 0x0004AB5A
			public unsafe static Func<ValueTuple<int, bool>, bool> __9__17_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, bool>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaSpot.__c.NativeFieldInfoPtr___9__17_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005CCD RID: 23757
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005CCE RID: 23758
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04005CCF RID: 23759
			private static readonly IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x04005CD0 RID: 23760
			private static readonly IntPtr NativeFieldInfoPtr___9__17_2;

			// Token: 0x04005CD1 RID: 23761
			private static readonly IntPtr NativeFieldInfoPtr___9__17_5;

			// Token: 0x04005CD2 RID: 23762
			private static readonly IntPtr NativeFieldInfoPtr___9__17_6;

			// Token: 0x04005CD3 RID: 23763
			private static readonly IntPtr NativeFieldInfoPtr___9__17_7;

			// Token: 0x04005CD4 RID: 23764
			private static readonly IntPtr NativeFieldInfoPtr___9__17_8;

			// Token: 0x04005CD5 RID: 23765
			private static readonly IntPtr NativeFieldInfoPtr___9__17_9;

			// Token: 0x04005CD6 RID: 23766
			private static readonly IntPtr NativeFieldInfoPtr___9__17_10;

			// Token: 0x04005CD7 RID: 23767
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005CD8 RID: 23768
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_0_Internal_Boolean_Boolean_0;

			// Token: 0x04005CD9 RID: 23769
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_1_Internal_Boolean_Boolean_0;

			// Token: 0x04005CDA RID: 23770
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_2_Internal_Boolean_Boolean_0;

			// Token: 0x04005CDB RID: 23771
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_5_Internal_ValueTuple_2_Int32_Boolean_Int32_Boolean_0;

			// Token: 0x04005CDC RID: 23772
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_6_Internal_Boolean_ValueTuple_2_Int32_Boolean_0;

			// Token: 0x04005CDD RID: 23773
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_7_Internal_ValueTuple_2_Int32_Boolean_Int32_Boolean_0;

			// Token: 0x04005CDE RID: 23774
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_8_Internal_Boolean_ValueTuple_2_Int32_Boolean_0;

			// Token: 0x04005CDF RID: 23775
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_9_Internal_ValueTuple_2_Int32_Boolean_Int32_Boolean_0;

			// Token: 0x04005CE0 RID: 23776
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_10_Internal_Boolean_ValueTuple_2_Int32_Boolean_0;
		}
	}
}
