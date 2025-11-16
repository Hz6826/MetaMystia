using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Plugins.DEYU;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.StorageUtility
{
	// Token: 0x02000387 RID: 903
	public class StorageMainPannel : MultiLayerUISubPanel<BaseSustainedPannel, StorageMainPannel, StorageMainPannel.GoToSpecificType>
	{
		// Token: 0x06006B49 RID: 27465 RVA: 0x0020473C File Offset: 0x0020293C
		// Note: this type is marked as 'beforefieldinit'.
		static StorageMainPannel()
		{
			Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.StorageUtility", "StorageMainPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr);
			StorageMainPannel.NativeFieldInfoPtr_ActionExecutionScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, "ActionExecutionScheduler");
			StorageMainPannel.NativeFieldInfoPtr_DescriberCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, "DescriberCanvasGroup");
			StorageMainPannel.NativeFieldInfoPtr_Describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, "Describer");
			StorageMainPannel.NativeFieldInfoPtr_ObjectStackParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, "ObjectStackParent");
			StorageMainPannel.NativeFieldInfoPtr_PinInputHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, "PinInputHelper");
			StorageMainPannel.NativeFieldInfoPtr_PinInputHelper2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, "PinInputHelper2");
			StorageMainPannel.NativeFieldInfoPtr_FloatingPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, "FloatingPannel");
			StorageMainPannel.NativeFieldInfoPtr_BG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, "BG");
			StorageMainPannel.NativeFieldInfoPtr_OtherPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, "OtherPannel");
			StorageMainPannel.NativeFieldInfoPtr_IngredientsBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, "IngredientsBtn");
			StorageMainPannel.NativeFieldInfoPtr_FoodsBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, "FoodsBtn");
			StorageMainPannel.NativeFieldInfoPtr_BeveragesBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, "BeveragesBtn");
			StorageMainPannel.NativeFieldInfoPtr_KitchenwareBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, "KitchenwareBtn");
			StorageMainPannel.NativeFieldInfoPtr_ItemBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, "ItemBtn");
			StorageMainPannel.NativeFieldInfoPtr__StandaloneMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, "<StandaloneMode>k__BackingField");
			StorageMainPannel.NativeMethodInfoPtr_get_StandaloneMode_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, 100685462);
			StorageMainPannel.NativeMethodInfoPtr_set_StandaloneMode_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, 100685463);
			StorageMainPannel.NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_GoToSpecificType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, 100685464);
			StorageMainPannel.NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_StorageMainPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, 100685465);
			StorageMainPannel.NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, 100685466);
			StorageMainPannel.NativeMethodInfoPtr_OnPostPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, 100685467);
			StorageMainPannel.NativeMethodInfoPtr_OnPanelPreOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, 100685468);
			StorageMainPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, 100685469);
			StorageMainPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, 100685470);
			StorageMainPannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, 100685471);
		}

		// Token: 0x170024C6 RID: 9414
		// (get) Token: 0x06006B4A RID: 27466 RVA: 0x00204960 File Offset: 0x00202B60
		// (set) Token: 0x06006B4B RID: 27467 RVA: 0x0020499C File Offset: 0x00202B9C
		public unsafe bool StandaloneMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMainPannel.NativeMethodInfoPtr_get_StandaloneMode_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMainPannel.NativeMethodInfoPtr_set_StandaloneMode_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170024C7 RID: 9415
		// (get) Token: 0x06006B4C RID: 27468 RVA: 0x002049DC File Offset: 0x00202BDC
		public unsafe override StorageMainPannel.GoToSpecificType DefaultPanelSelection
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMainPannel.NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_GoToSpecificType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170024C8 RID: 9416
		// (get) Token: 0x06006B4D RID: 27469 RVA: 0x00204A24 File Offset: 0x00202C24
		public unsafe override IEnumerable<ValueTuple<StorageMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<StorageMainPannel>>> GetData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271923, XrefRangeEnd = 271929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMainPannel.NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_StorageMainPannel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<StorageMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<StorageMainPannel>>>>(intPtr3) : null;
			}
		}

		// Token: 0x170024C9 RID: 9417
		// (get) Token: 0x06006B4E RID: 27470 RVA: 0x00204A70 File Offset: 0x00202C70
		public unsafe override string SwitchKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMainPannel.NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06006B4F RID: 27471 RVA: 0x00204AB4 File Offset: 0x00202CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271929, XrefRangeEnd = 271933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPostPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMainPannel.NativeMethodInfoPtr_OnPostPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B50 RID: 27472 RVA: 0x00204AF0 File Offset: 0x00202CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271933, XrefRangeEnd = 271942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelPreOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMainPannel.NativeMethodInfoPtr_OnPanelPreOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B51 RID: 27473 RVA: 0x00204B2C File Offset: 0x00202D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271942, XrefRangeEnd = 271959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMainPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B52 RID: 27474 RVA: 0x00204B68 File Offset: 0x00202D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271959, XrefRangeEnd = 271962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageMainPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMainPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B53 RID: 27475 RVA: 0x00204BA4 File Offset: 0x00202DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271962, XrefRangeEnd = 271965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Common_UI_IExternalPanel_CloseExternPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMainPannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B54 RID: 27476 RVA: 0x0003A0D0 File Offset: 0x000382D0
		public StorageMainPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024B7 RID: 9399
		// (get) Token: 0x06006B55 RID: 27477 RVA: 0x00204BD8 File Offset: 0x00202DD8
		// (set) Token: 0x06006B56 RID: 27478 RVA: 0x0003A0D9 File Offset: 0x000382D9
		public unsafe ActionExecutionScheduler ActionExecutionScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_ActionExecutionScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_ActionExecutionScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B8 RID: 9400
		// (get) Token: 0x06006B57 RID: 27479 RVA: 0x00204C08 File Offset: 0x00202E08
		// (set) Token: 0x06006B58 RID: 27480 RVA: 0x0003A0F8 File Offset: 0x000382F8
		public unsafe CanvasGroup DescriberCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_DescriberCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_DescriberCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B9 RID: 9401
		// (get) Token: 0x06006B59 RID: 27481 RVA: 0x00204C38 File Offset: 0x00202E38
		// (set) Token: 0x06006B5A RID: 27482 RVA: 0x0003A117 File Offset: 0x00038317
		public unsafe SellableDescriber Describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_Describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_Describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BA RID: 9402
		// (get) Token: 0x06006B5B RID: 27483 RVA: 0x00204C68 File Offset: 0x00202E68
		// (set) Token: 0x06006B5C RID: 27484 RVA: 0x0003A136 File Offset: 0x00038336
		public unsafe GameObject ObjectStackParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_ObjectStackParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_ObjectStackParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BB RID: 9403
		// (get) Token: 0x06006B5D RID: 27485 RVA: 0x00204C98 File Offset: 0x00202E98
		// (set) Token: 0x06006B5E RID: 27486 RVA: 0x0003A155 File Offset: 0x00038355
		public unsafe GameObject PinInputHelper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_PinInputHelper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_PinInputHelper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BC RID: 9404
		// (get) Token: 0x06006B5F RID: 27487 RVA: 0x00204CC8 File Offset: 0x00202EC8
		// (set) Token: 0x06006B60 RID: 27488 RVA: 0x0003A174 File Offset: 0x00038374
		public unsafe GameObject PinInputHelper2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_PinInputHelper2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_PinInputHelper2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BD RID: 9405
		// (get) Token: 0x06006B61 RID: 27489 RVA: 0x00204CF8 File Offset: 0x00202EF8
		// (set) Token: 0x06006B62 RID: 27490 RVA: 0x0003A193 File Offset: 0x00038393
		public unsafe RectTransform FloatingPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_FloatingPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_FloatingPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BE RID: 9406
		// (get) Token: 0x06006B63 RID: 27491 RVA: 0x00204D28 File Offset: 0x00202F28
		// (set) Token: 0x06006B64 RID: 27492 RVA: 0x0003A1B2 File Offset: 0x000383B2
		public unsafe Image BG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_BG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_BG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BF RID: 9407
		// (get) Token: 0x06006B65 RID: 27493 RVA: 0x00204D58 File Offset: 0x00202F58
		// (set) Token: 0x06006B66 RID: 27494 RVA: 0x0003A1D1 File Offset: 0x000383D1
		public unsafe StorageOtherPannel OtherPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_OtherPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageOtherPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_OtherPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C0 RID: 9408
		// (get) Token: 0x06006B67 RID: 27495 RVA: 0x00204D88 File Offset: 0x00202F88
		// (set) Token: 0x06006B68 RID: 27496 RVA: 0x0003A1F0 File Offset: 0x000383F0
		public unsafe UIButtonToggle IngredientsBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_IngredientsBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_IngredientsBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C1 RID: 9409
		// (get) Token: 0x06006B69 RID: 27497 RVA: 0x00204DB8 File Offset: 0x00202FB8
		// (set) Token: 0x06006B6A RID: 27498 RVA: 0x0003A20F File Offset: 0x0003840F
		public unsafe UIButtonToggle FoodsBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_FoodsBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_FoodsBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C2 RID: 9410
		// (get) Token: 0x06006B6B RID: 27499 RVA: 0x00204DE8 File Offset: 0x00202FE8
		// (set) Token: 0x06006B6C RID: 27500 RVA: 0x0003A22E File Offset: 0x0003842E
		public unsafe UIButtonToggle BeveragesBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_BeveragesBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_BeveragesBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C3 RID: 9411
		// (get) Token: 0x06006B6D RID: 27501 RVA: 0x00204E18 File Offset: 0x00203018
		// (set) Token: 0x06006B6E RID: 27502 RVA: 0x0003A24D File Offset: 0x0003844D
		public unsafe UIButtonToggle KitchenwareBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_KitchenwareBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_KitchenwareBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C4 RID: 9412
		// (get) Token: 0x06006B6F RID: 27503 RVA: 0x00204E48 File Offset: 0x00203048
		// (set) Token: 0x06006B70 RID: 27504 RVA: 0x0003A26C File Offset: 0x0003846C
		public unsafe UIButtonToggle ItemBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_ItemBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr_ItemBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C5 RID: 9413
		// (get) Token: 0x06006B71 RID: 27505 RVA: 0x00204E78 File Offset: 0x00203078
		// (set) Token: 0x06006B72 RID: 27506 RVA: 0x0003A28B File Offset: 0x0003848B
		public unsafe bool _StandaloneMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr__StandaloneMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel.NativeFieldInfoPtr__StandaloneMode_k__BackingField)) = value;
			}
		}

		// Token: 0x04004720 RID: 18208
		private static readonly IntPtr NativeFieldInfoPtr_ActionExecutionScheduler;

		// Token: 0x04004721 RID: 18209
		private static readonly IntPtr NativeFieldInfoPtr_DescriberCanvasGroup;

		// Token: 0x04004722 RID: 18210
		private static readonly IntPtr NativeFieldInfoPtr_Describer;

		// Token: 0x04004723 RID: 18211
		private static readonly IntPtr NativeFieldInfoPtr_ObjectStackParent;

		// Token: 0x04004724 RID: 18212
		private static readonly IntPtr NativeFieldInfoPtr_PinInputHelper;

		// Token: 0x04004725 RID: 18213
		private static readonly IntPtr NativeFieldInfoPtr_PinInputHelper2;

		// Token: 0x04004726 RID: 18214
		private static readonly IntPtr NativeFieldInfoPtr_FloatingPannel;

		// Token: 0x04004727 RID: 18215
		private static readonly IntPtr NativeFieldInfoPtr_BG;

		// Token: 0x04004728 RID: 18216
		private static readonly IntPtr NativeFieldInfoPtr_OtherPannel;

		// Token: 0x04004729 RID: 18217
		private static readonly IntPtr NativeFieldInfoPtr_IngredientsBtn;

		// Token: 0x0400472A RID: 18218
		private static readonly IntPtr NativeFieldInfoPtr_FoodsBtn;

		// Token: 0x0400472B RID: 18219
		private static readonly IntPtr NativeFieldInfoPtr_BeveragesBtn;

		// Token: 0x0400472C RID: 18220
		private static readonly IntPtr NativeFieldInfoPtr_KitchenwareBtn;

		// Token: 0x0400472D RID: 18221
		private static readonly IntPtr NativeFieldInfoPtr_ItemBtn;

		// Token: 0x0400472E RID: 18222
		private static readonly IntPtr NativeFieldInfoPtr__StandaloneMode_k__BackingField;

		// Token: 0x0400472F RID: 18223
		private static readonly IntPtr NativeMethodInfoPtr_get_StandaloneMode_Private_get_Boolean_0;

		// Token: 0x04004730 RID: 18224
		private static readonly IntPtr NativeMethodInfoPtr_set_StandaloneMode_Public_set_Void_Boolean_0;

		// Token: 0x04004731 RID: 18225
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_GoToSpecificType_0;

		// Token: 0x04004732 RID: 18226
		private static readonly IntPtr NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_StorageMainPannel_0;

		// Token: 0x04004733 RID: 18227
		private static readonly IntPtr NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0;

		// Token: 0x04004734 RID: 18228
		private static readonly IntPtr NativeMethodInfoPtr_OnPostPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004735 RID: 18229
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelPreOpen_Protected_Virtual_Void_0;

		// Token: 0x04004736 RID: 18230
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004737 RID: 18231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004738 RID: 18232
		private static readonly IntPtr NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0;

		// Token: 0x02000EA7 RID: 3751
		public enum GoToSpecificType
		{
			// Token: 0x0400A7C1 RID: 42945
			Ingredients,
			// Token: 0x0400A7C2 RID: 42946
			Foods,
			// Token: 0x0400A7C3 RID: 42947
			Beverages,
			// Token: 0x0400A7C4 RID: 42948
			Kitchenware,
			// Token: 0x0400A7C5 RID: 42949
			Item
		}

		// Token: 0x02000EA8 RID: 3752
		[ObfuscatedName("Common.UI.StorageUtility.StorageMainPannel+<get_GetData>d__22")]
		public sealed class _get_GetData_d__22 : Il2CppSystem.Object
		{
			// Token: 0x0601093F RID: 67903 RVA: 0x003D75A4 File Offset: 0x003D57A4
			// Note: this type is marked as 'beforefieldinit'.
			static _get_GetData_d__22()
			{
				Il2CppClassPointerStore<StorageMainPannel._get_GetData_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageMainPannel>.NativeClassPtr, "<get_GetData>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageMainPannel._get_GetData_d__22>.NativeClassPtr);
				StorageMainPannel._get_GetData_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel._get_GetData_d__22>.NativeClassPtr, "<>1__state");
				StorageMainPannel._get_GetData_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel._get_GetData_d__22>.NativeClassPtr, "<>2__current");
				StorageMainPannel._get_GetData_d__22.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel._get_GetData_d__22>.NativeClassPtr, "<>l__initialThreadId");
				StorageMainPannel._get_GetData_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMainPannel._get_GetData_d__22>.NativeClassPtr, "<>4__this");
				StorageMainPannel._get_GetData_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel._get_GetData_d__22>.NativeClassPtr, 100685472);
				StorageMainPannel._get_GetData_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel._get_GetData_d__22>.NativeClassPtr, 100685473);
				StorageMainPannel._get_GetData_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel._get_GetData_d__22>.NativeClassPtr, 100685474);
				StorageMainPannel._get_GetData_d__22.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_StorageMainPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel._get_GetData_d__22>.NativeClassPtr, 100685475);
				StorageMainPannel._get_GetData_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel._get_GetData_d__22>.NativeClassPtr, 100685476);
				StorageMainPannel._get_GetData_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel._get_GetData_d__22>.NativeClassPtr, 100685477);
				StorageMainPannel._get_GetData_d__22.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_StorageMainPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel._get_GetData_d__22>.NativeClassPtr, 100685478);
				StorageMainPannel._get_GetData_d__22.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMainPannel._get_GetData_d__22>.NativeClassPtr, 100685479);
			}

			// Token: 0x06010940 RID: 67904 RVA: 0x003D76C0 File Offset: 0x003D58C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_GetData_d__22(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageMainPannel._get_GetData_d__22>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMainPannel._get_GetData_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010941 RID: 67905 RVA: 0x003D7708 File Offset: 0x003D5908
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMainPannel._get_GetData_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010942 RID: 67906 RVA: 0x003D773C File Offset: 0x003D593C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271908, XrefRangeEnd = 271912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMainPannel._get_GetData_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700567F RID: 22143
			// (get) Token: 0x06010943 RID: 67907 RVA: 0x003D7778 File Offset: 0x003D5978
			public unsafe ValueTuple<StorageMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<StorageMainPannel>> prop_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_StorageMainPannel_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(StorageMainPannel._get_GetData_d__22.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_StorageMainPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new ValueTuple<StorageMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<StorageMainPannel>>(pointer);
				}
			}

			// Token: 0x06010944 RID: 67908 RVA: 0x003D77B0 File Offset: 0x003D59B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271912, XrefRangeEnd = 271918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMainPannel._get_GetData_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005680 RID: 22144
			// (get) Token: 0x06010945 RID: 67909 RVA: 0x003D77E4 File Offset: 0x003D59E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271918, XrefRangeEnd = 271921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMainPannel._get_GetData_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06010946 RID: 67910 RVA: 0x003D7824 File Offset: 0x003D5A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271921, XrefRangeEnd = 271923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<StorageMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<StorageMainPannel>>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_StorageMainPannel_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMainPannel._get_GetData_d__22.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_StorageMainPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<StorageMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<StorageMainPannel>>>>(intPtr3) : null;
			}

			// Token: 0x06010947 RID: 67911 RVA: 0x003D7864 File Offset: 0x003D5A64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMainPannel._get_GetData_d__22.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06010948 RID: 67912 RVA: 0x00090B19 File Offset: 0x0008ED19
			public _get_GetData_d__22(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700567B RID: 22139
			// (get) Token: 0x06010949 RID: 67913 RVA: 0x003D78A4 File Offset: 0x003D5AA4
			// (set) Token: 0x0601094A RID: 67914 RVA: 0x00090B22 File Offset: 0x0008ED22
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel._get_GetData_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel._get_GetData_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700567C RID: 22140
			// (get) Token: 0x0601094B RID: 67915 RVA: 0x003D78CC File Offset: 0x003D5ACC
			// (set) Token: 0x0601094C RID: 67916 RVA: 0x00090B3D File Offset: 0x0008ED3D
			public ValueTuple<StorageMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<StorageMainPannel>> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel._get_GetData_d__22.NativeFieldInfoPtr___2__current);
					return new ValueTuple<StorageMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<StorageMainPannel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<StorageMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<StorageMainPannel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel._get_GetData_d__22.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<StorageMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<StorageMainPannel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700567D RID: 22141
			// (get) Token: 0x0601094D RID: 67917 RVA: 0x003D78FC File Offset: 0x003D5AFC
			// (set) Token: 0x0601094E RID: 67918 RVA: 0x00090B6B File Offset: 0x0008ED6B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel._get_GetData_d__22.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel._get_GetData_d__22.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700567E RID: 22142
			// (get) Token: 0x0601094F RID: 67919 RVA: 0x003D7924 File Offset: 0x003D5B24
			// (set) Token: 0x06010950 RID: 67920 RVA: 0x00090B86 File Offset: 0x0008ED86
			public unsafe StorageMainPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel._get_GetData_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageMainPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMainPannel._get_GetData_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7C6 RID: 42950
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A7C7 RID: 42951
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A7C8 RID: 42952
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400A7C9 RID: 42953
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7CA RID: 42954
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A7CB RID: 42955
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A7CC RID: 42956
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A7CD RID: 42957
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_StorageMainPannel_0;

			// Token: 0x0400A7CE RID: 42958
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A7CF RID: 42959
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A7D0 RID: 42960
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_StorageMainPannel_0;

			// Token: 0x0400A7D1 RID: 42961
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
